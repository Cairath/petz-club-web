import {
  DeleteIcon,
  EditIcon,
  LinkIcon,
  SmallCloseIcon
} from "@chakra-ui/icons";
import {
  Badge,
  Flex,
  IconButton,
  Tbody,
  Td,
  Text,
  Th,
  Thead,
  Tooltip,
  Tr
} from "@chakra-ui/react";
import { DateTime } from "luxon";
import { FaRegTrashAlt } from "react-icons/fa";
import { FiArchive } from "react-icons/fi";
import { MdRefresh } from "react-icons/md";
import { Link as ReactRouterLink } from "react-router-dom";
import { AffixStatus, RegisteredAffixListItem } from "../../../api/client";
import { ButtonWithConfirmationPopover } from "../../../components/ButtonWithConfirmationPopover";
import { NoResultsRow } from "../../../components/NoResultsRow";
import { ShowNameText } from "../../../components/ShowNameText";
import { affixStatusDisplayData, syntaxDisplayName } from "../../../utils";

export type Props = {
  affixes: RegisteredAffixListItem[];
  headers: string[];
  pt?: string;
  type?: "registered" | "pending";
  cancelRegistration: (pendingAffixId: number) => void;
  deleteAffix: (affixId: number) => void;
  setActiveStatus: (affixId: number, active: boolean) => void;
};

export const RegisteredAffixesTableContent = ({
  affixes,
  headers,
  pt,
  type = "registered",
  cancelRegistration,
  deleteAffix,
  setActiveStatus
}: Props) => {
  return (
    <>
      <Thead>
        <Tr color="gray.400">
          {headers.map((header, idx) => {
            return (
              <Th color="gray.400" key={idx} pt={pt ?? "12px"}>
                {header}
              </Th>
            );
          })}
        </Tr>
      </Thead>
      <Tbody>
        {affixes.length > 0 ? (
          affixes.map((affix: RegisteredAffixListItem) => (
            <TableRow
              affix={affix}
              type={type}
              cancelRegistration={cancelRegistration}
              deleteAffix={deleteAffix}
              setActiveStatus={setActiveStatus}
            />
          ))
        ) : (
          <NoResultsRow colSpan={headers.length} />
        )}
      </Tbody>
    </>
  );
};

type TableRowProps = {
  affix: RegisteredAffixListItem;
  type?: "registered" | "pending";
  cancelRegistration: (pendingAffixId: number) => void;
  deleteAffix: (affixId: number) => void;
  setActiveStatus: (affixId: number, active: boolean) => void;
};

const TableRow = ({
  affix,
  type,
  cancelRegistration,
  deleteAffix,
  setActiveStatus
}: TableRowProps) => {
  const actionsRegistered = () => {
    return (
      <>
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
      </>
    );
  };

  const actions = () => {
    if (type === "registered") {
      return actionsRegistered();
    } else
      return (
        <ButtonWithConfirmationPopover
          tooltip="Cancel registration"
          prompt="Are you sure you want to cancel this registration?"
          confirmationButtonText="Reject"
          confirmationButtonColor="red"
          icon={<SmallCloseIcon />}
          objectId={affix.id}
          onConfirm={cancelRegistration}
        />
      );
  };

  return (
    <Tr key={`affix-${affix.id}`}>
      <Td>
        <Text fontWeight="bold">{affix.name}</Text>
      </Td>
      <Td>
        <Text>{syntaxDisplayName[affix.syntax]}</Text>
      </Td>
      <Td>
        <ShowNameText affixName={affix.name} affixSyntax={affix.syntax} />
      </Td>
      <Td>
        <Text>{type === "registered" ? affix.petsCount : ""}</Text>
      </Td>
      <Td>
        <Badge
          w="70px"
          textAlign={"center"}
          colorScheme={affixStatusDisplayData[affix.status].color}
          variant="subtle"
        >
          {affixStatusDisplayData[affix.status].name}
        </Badge>
      </Td>
      <Td>
        <Text>
          {DateTime.fromJSDate(affix.registrationDate).toFormat("yyyy/MM/dd")}
        </Text>
      </Td>
      <Td>
        <Flex direction="row">{actions()}</Flex>
      </Td>
    </Tr>
  );
};
