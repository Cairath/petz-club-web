import { CheckIcon, SmallCloseIcon } from "@chakra-ui/icons";
import { Flex, Link, Text } from "@chakra-ui/react";
import { createColumnHelper, SortingState } from "@tanstack/react-table";
import { DateTime } from "luxon";
import { useMemo } from "react";
import { Link as ReactRouterLink } from "react-router-dom";
import { PendingAffixRegistration, SimilarName } from "../../../../api/client";
import { BasicTable } from "../../../../components/BasicTable";
import { ButtonWithConfirmationPopover } from "../../../../components/ButtonWithConfirmationPopover";
import { ShowNameText } from "../../../../components/ShowNameText";
import { Space } from "../../../../components/Space";
import { syntaxDisplayName } from "../../../../utils";

export type Props = {
  affixes: PendingAffixRegistration[];
  reject: (pendingAffixId: number, reason: string) => void;
  approve: (pendingAffixId: number) => void;
};

export const PendingAffixRegistrationsTable = ({
  affixes,
  reject,
  approve
}: Props) => {
  const columnHelper = createColumnHelper<PendingAffixRegistration>();
  const columns = useMemo(
    () => [
      columnHelper.accessor("name", {
        header: "Name",
        meta: { width: "20%", minWidth: "200px" },
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
        meta: { width: "20%", minWidth: "250px" },
        cell: (props) => (
          <ShowNameText
            affixName={props.row.original.name}
            affixSyntax={props.row.original.syntax}
          />
        )
      }),
      columnHelper.accessor("similarNames", {
        header: "Similar Names",
        meta: { width: "20%", minWidth: "200px" },
        enableSorting: false,
        enableColumnFilter: false,
        cell: (props) => (
          <Flex direction="column">
            {props.getValue().map((similarName: SimilarName) => (
              <Text color="gray.500" fontWeight="bold">
                <Link as={ReactRouterLink} to={`/affix/${similarName.id}`}>
                  {similarName.name} ({syntaxDisplayName[similarName.syntax]})
                  <Space />-<Space />
                  {similarName.similarityPercentage}%
                </Link>
              </Text>
            ))}
          </Flex>
        )
      }),
      columnHelper.accessor("ownerName", {
        header: "Submitter",
        meta: { width: "10%", minWidth: "100px" },
        cell: (props) => (
          <Text color="gray.500" fontWeight="bold">
            <Link
              as={ReactRouterLink}
              to={`/member/${props.row.original.ownerId}`}
            >
              {props.getValue()}
            </Link>
          </Text>
        )
      }),
      columnHelper.accessor("submissionDate", {
        header: "Submission Date",
        meta: { minWidth: "250px" },
        enableColumnFilter: false,
        cell: (props) => (
          <Text>
            {DateTime.fromJSDate(props.getValue()).toFormat("yyyy/MM/dd")}
          </Text>
        )
      }),
      columnHelper.display({
        header: "Actions",
        meta: { width: "10%" },
        id: "actions",
        cell: (props) => (
          <Flex direction="row">
            <ButtonWithConfirmationPopover
              tooltip="Reject"
              prompt="Reject this affix registration?"
              confirmationButtonText="Reject"
              confirmationButtonColor="red"
              icon={<SmallCloseIcon color="red.500" />}
              objectId={props.row.original.id}
              withReason
              onConfirm={reject}
              mr="5px"
            />
            <ButtonWithConfirmationPopover
              tooltip="Approve"
              prompt="Approve this affix registration?"
              confirmationButtonText="Approve"
              confirmationButtonColor="green"
              icon={<CheckIcon color="green.500" />}
              objectId={props.row.original.id}
              onConfirm={approve}
            />
          </Flex>
        )
      })
    ],
    [columnHelper, reject, approve]
  );

  const initialSortingState: SortingState = [
    { id: "submissionDate", desc: false }
  ];

  return (
    <BasicTable
      data={affixes}
      columns={columns}
      initialSortingState={initialSortingState}
      useColGroups={true}
    />
  );
};
