import { CheckIcon, SmallCloseIcon } from "@chakra-ui/icons";
import {
  Flex,
  Link,
  Table,
  Tbody,
  Td,
  Text,
  Th,
  Thead,
  Tr
} from "@chakra-ui/react";
import { DateTime } from "luxon";
import { Link as ReactRouterLink } from "react-router-dom";
import { PendingAffixRegistration, SimilarName } from "../../../../api/client";
import { ButtonWithConfirmationPopover } from "../../../../components/ButtonWithConfirmationPopover";
import { NoResultsRow } from "../../../../components/NoResultsRow";
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
  const headers = [
    "Name",
    "Syntax",
    "Show Name Construction",
    "Similar Names",
    "Submitter",
    "Submission date",
    "Actions"
  ];

  return (
    <Table>
      <Thead>
        <Tr color="gray.400">
          {headers.map((header, idx) => {
            return (
              <Th color="gray.400" key={idx}>
                {header}
              </Th>
            );
          })}
        </Tr>
      </Thead>
      <Tbody>
        {affixes.length > 0 ? (
          affixes.map((affix: PendingAffixRegistration) => (
            <TableRow affix={affix} reject={reject} approve={approve} />
          ))
        ) : (
          <NoResultsRow colSpan={headers.length} />
        )}
      </Tbody>
    </Table>
  );
};

type TableRowProps = {
  affix: PendingAffixRegistration;
  reject: (pendingAffixId: number, reason: string) => void;
  approve: (pendingAffixId: number) => void;
};

const TableRow = ({ affix, reject, approve }: TableRowProps) => {
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
        <Flex direction="column">
          {affix.similarNames.map((similarName: SimilarName) => (
            <Text color="gray.500" fontWeight="bold">
              <Link as={ReactRouterLink} to={`/affix/${similarName.id}`}>
                {similarName.name} ({syntaxDisplayName[similarName.syntax]})
                <Space />-<Space />
                {similarName.similarityPercentage}%
              </Link>
            </Text>
          ))}
        </Flex>
      </Td>
      <Td>
        <Text color="gray.500" fontWeight="bold">
          <Link as={ReactRouterLink} to={`/member/${affix.ownerId}`}>
            {affix.ownerName}
          </Link>
        </Text>
      </Td>
      <Td>
        <Text>
          {DateTime.fromJSDate(affix.submissionDate).toFormat("yyyy/MM/dd")}
        </Text>
      </Td>
      <Td>
        <Flex direction="row">
          <ButtonWithConfirmationPopover
            tooltip="Reject"
            prompt="Reject this affix registration?"
            confirmationButtonText="Reject"
            confirmationButtonColor="red"
            icon={<SmallCloseIcon color="red.500" />}
            objectId={affix.id}
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
            objectId={affix.id}
            onConfirm={approve}
          />
        </Flex>
      </Td>
    </Tr>
  );
};
