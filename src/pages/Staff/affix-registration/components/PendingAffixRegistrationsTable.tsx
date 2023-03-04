import { CheckIcon, CloseIcon } from "@chakra-ui/icons";
import {
  Flex,
  IconButton,
  Link,
  Table,
  Tbody,
  Td,
  Text,
  Th,
  Thead,
  Tooltip,
  Tr
} from "@chakra-ui/react";
import { DateTime } from "luxon";
import { Link as ReactRouterLink } from "react-router-dom";
import { PendingAffixRegistration, SimilarName } from "../../../../api/client";
import { ShowNameText } from "../../../../components/ShowNameText";
import { Space } from "../../../../components/Space";
import { syntaxDisplayName } from "../../../../utils";

export type Props = {
  affixes: PendingAffixRegistration[];
  reject: (pendingAffixId: number, reason: string) => void;
  accept: (pendingAffixId: number) => void;
};

export const PendingAffixRegistrationsTable = ({
  affixes,
  reject,
  accept
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
        {affixes.map((affix: PendingAffixRegistration) => (
          <TableRow
            affix={affix}
            //cancelRegistration={cancelRegistration}
          />
        ))}
      </Tbody>
    </Table>
  );
};

type TableRowProps = {
  affix: PendingAffixRegistration;
  // cancelRegistration: (pendingAffixId: number) => void;
};

const TableRow = ({
  affix
}: // cancelRegistration
TableRowProps) => {
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
          <Tooltip label="Reject">
            <IconButton
              variant="outline"
              color="red.500"
              mr="5px"
              aria-label="link"
              icon={<CloseIcon w="16px" h="16px" />}
            />
          </Tooltip>
          <Tooltip label="Accept">
            <IconButton
              variant="outline"
              color="green.500"
              aria-label="edit"
              icon={<CheckIcon w="16px" h="16px" />}
            />
          </Tooltip>
        </Flex>
      </Td>
    </Tr>
  );
};
