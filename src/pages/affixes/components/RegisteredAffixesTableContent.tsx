import { EditIcon, LinkIcon, NotAllowedIcon } from "@chakra-ui/icons";
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
import { Link as ReactRouterLink } from "react-router-dom";
import { RegisteredAffixListItem } from "../../../api/client";
import { ShowNameText } from "../../../components/ShowNameText";
import { affixStatusDisplayData, syntaxDisplayName } from "../../../utils";
import { CancelRegistrationButton } from "./CancelRegistrationButton";

export type Props = {
  affixes: RegisteredAffixListItem[];
  headers: string[];
  pt?: string;
  type?: "registered" | "pending";
  cancelRegistration: (pendingAffixId: number) => void;
};

export const RegisteredAffixesTableContent = ({
  affixes,
  headers,
  pt,
  type = "registered",
  cancelRegistration
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
        {affixes.map((affix: RegisteredAffixListItem) => (
          <TableRow
            affix={affix}
            type={type}
            cancelRegistration={cancelRegistration}
          />
        ))}
      </Tbody>
    </>
  );
};

type TableRowProps = {
  affix: RegisteredAffixListItem;
  type?: "registered" | "pending";
  cancelRegistration: (pendingAffixId: number) => void;
};

const TableRow = ({ affix, type, cancelRegistration }: TableRowProps) => {
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
        <Flex direction="row">
          {type === "registered" ? (
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
                  variant="outline"
                  mr="5px"
                  aria-label="edit"
                  icon={<EditIcon />}
                />
              </Tooltip>
              <Tooltip label="Deactivate">
                <IconButton
                  variant="outline"
                  aria-label="deactivate"
                  icon={<NotAllowedIcon />}
                />
              </Tooltip>
            </>
          ) : (
            <CancelRegistrationButton
              pendingAffixId={affix.id}
              onConfirm={cancelRegistration}
            />
          )}
        </Flex>
      </Td>
    </Tr>
  );
};
