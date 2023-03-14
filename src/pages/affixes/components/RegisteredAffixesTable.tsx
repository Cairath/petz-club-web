import { EditIcon, LinkIcon, SmallCloseIcon } from "@chakra-ui/icons";
import {
  Badge,
  Flex,
  IconButton,
  Table,
  Text,
  Tooltip,
  useColorModeValue
} from "@chakra-ui/react";
import { createColumnHelper, SortingState } from "@tanstack/react-table";
import { DateTime } from "luxon";
import { useMemo } from "react";
import { FaRegTrashAlt } from "react-icons/fa";
import { FiArchive } from "react-icons/fi";
import { MdRefresh } from "react-icons/md";
import { Link as ReactRouterLink } from "react-router-dom";
import { AffixStatus, AffixListItem } from "../../../api/client";
import { BasicTable } from "../../../components/BasicTable";
import { ButtonWithConfirmationPopover } from "../../../components/ButtonWithConfirmationPopover";
import { ShowNameText } from "../../../components/ShowNameText";
import { affixStatusDisplayData, syntaxDisplayName } from "../../../utils";

export type Props = {
  pendingAffixes: AffixListItem[];
  registeredAffixes: AffixListItem[];
  cancelRegistration: (pendingAffixId: number) => void;
  deleteAffix: (affixId: number) => void;
  setActiveStatus: (affixId: number, active: boolean) => void;
};

export const RegisteredAffixesTable = ({
  pendingAffixes,
  registeredAffixes,
  cancelRegistration,
  deleteAffix,
  setActiveStatus
}: Props) => {
  const textColor = useColorModeValue("gray.700", "white");
  const columnHelper = createColumnHelper<AffixListItem>();

  const nameColumns = useMemo(() => {
    return [
      columnHelper.accessor("name", {
        header: "Name",
        meta: { width: "22%", minWidth: "200px" },
        cell: (props) => <Text fontWeight="bold">{props.getValue()}</Text>
      }),
      columnHelper.accessor("syntax", {
        header: "Syntax",
        meta: { width: "8%", minWidth: "100px" },
        cell: (props) => <Text>{syntaxDisplayName[props.getValue()]}</Text>
      }),
      columnHelper.display({
        header: "Show name construction",
        id: "showName",
        meta: { width: "30%", minWidth: "250px" },
        cell: (props) => (
          <ShowNameText
            affixName={props.row.original.name}
            affixSyntax={props.row.original.syntax}
          />
        )
      }),
      columnHelper.accessor("status", {
        header: "Status",
        meta: { width: "8%", minWidth: "100px" },
        cell: (props) => (
          <Badge
            w="70px"
            textAlign="center"
            colorScheme={affixStatusDisplayData[props.getValue()].color}
            variant="subtle"
          >
            {affixStatusDisplayData[props.getValue()].name}
          </Badge>
        )
      })
    ];
  }, [columnHelper]);

  const pendingAffixesColumns = useMemo(
    () => [
      ...nameColumns,
      columnHelper.display({
        header: "",
        id: "gap"
      }),
      columnHelper.accessor("registrationDate", {
        header: "Submission date",
        cell: (props) => (
          <Text>
            {DateTime.fromJSDate(props.getValue()).toFormat("yyyy/MM/dd")}
          </Text>
        )
      }),
      columnHelper.display({
        header: "Actions",
        id: "actions",
        cell: (props) => (
          <ButtonWithConfirmationPopover
            tooltip="Cancel registration"
            prompt="Are you sure you want to cancel this registration?"
            confirmationButtonText="Cancel"
            confirmationButtonColor="red"
            icon={<SmallCloseIcon />}
            objectId={props.row.original.id}
            onConfirm={cancelRegistration}
          />
        )
      })
    ],
    [columnHelper, nameColumns, cancelRegistration]
  );

  const registeredAffixesColumns = useMemo(
    () => [
      ...nameColumns,
      columnHelper.accessor("petsCount", {
        header: "Pet Count",
        meta: { width: "8%", minWidth: "100px" },
        cell: (props) => <Text>{props.getValue()}</Text>
      }),

      columnHelper.accessor("registrationDate", {
        header: "Registration date",
        meta: { width: "12%", minWidth: "150px" },
        cell: (props) => (
          <Text>
            {DateTime.fromJSDate(props.getValue()).toFormat("yyyy/MM/dd")}
          </Text>
        )
      }),
      columnHelper.display({
        header: "Actions",
        id: "actions",
        meta: { minWidth: "150px" },
        cell: (props) => {
          const affix = props.row.original;

          return (
            <Flex direction="row">
              <Tooltip label="Go to the affix page">
                <ReactRouterLink to={`/affix/${affix.id}`}>
                  <IconButton
                    variant="outline"
                    mr="5px"
                    aria-label="link"
                    icon={<LinkIcon />}
                  />
                </ReactRouterLink>
              </Tooltip>

              <Tooltip label="Request edit">
                <IconButton
                  visibility={
                    affix.status === AffixStatus.Active ? "visible" : "hidden"
                  }
                  variant="outline"
                  mr="5px"
                  aria-label="edit"
                  icon={<EditIcon />}
                />
              </Tooltip>
              {affix.petsCount > 0 ? (
                affix.status === AffixStatus.Active ? (
                  <ButtonWithConfirmationPopover
                    tooltip="Deactivate"
                    prompt="Deactivate the affix? You will be able to reactivate it later."
                    confirmationButtonText="Deactivate"
                    confirmationButtonColor="red"
                    icon={<FiArchive />}
                    objectId={affix.id}
                    onConfirm={() => setActiveStatus(affix.id, false)}
                  />
                ) : (
                  <ButtonWithConfirmationPopover
                    tooltip="Activate"
                    prompt="Reactivate the affix?"
                    confirmationButtonText="Activate"
                    confirmationButtonColor="green"
                    icon={<MdRefresh />}
                    objectId={affix.id}
                    onConfirm={() => setActiveStatus(affix.id, true)}
                  />
                )
              ) : (
                <ButtonWithConfirmationPopover
                  tooltip="Delete affix"
                  prompt="Are you sure you want to remove this affix? This action is irreversible, you will have to go through the registration process again, and the name will be free to use by everyone"
                  confirmationButtonText="Delete"
                  confirmationButtonColor="red"
                  icon={<FaRegTrashAlt color="red" />}
                  objectId={affix.id}
                  onConfirm={deleteAffix}
                />
              )}
            </Flex>
          );
        }
      })
    ],
    [columnHelper, nameColumns, deleteAffix, setActiveStatus]
  );

  const showPending = useMemo(
    () => pendingAffixes.length > 0,
    [pendingAffixes]
  );

  const pendingInitialSortingState: SortingState = [
    { id: "registrationDate", desc: true }
  ];
  const initialSortingState: SortingState = [{ id: "name", desc: false }];

  return (
    <Table color={textColor} layout="fixed">
      {showPending && (
        <BasicTable
          data={pendingAffixes}
          columns={pendingAffixesColumns}
          withTableTag={false}
          initialSortingState={pendingInitialSortingState}
        />
      )}
      <BasicTable
        data={registeredAffixes}
        columns={registeredAffixesColumns}
        withTableTag={false}
        initialSortingState={initialSortingState}
        useColGroups={true}
      />
    </Table>
  );
};
