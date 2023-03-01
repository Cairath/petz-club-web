import {
  Table,
  Tbody,
  Td,
  Th,
  Thead,
  Tr,
  useColorModeValue
} from "@chakra-ui/react";
import { DateTime } from "luxon";
import { AffixSyntax, RegisteredAffixListItem } from "../../../api/client";
import { ShowNameText } from "./ShowNameText";

export type Props = {
  affixes: RegisteredAffixListItem[];
};

const syntaxDisplayName: Record<AffixSyntax, string> = {
  [AffixSyntax.Prefix]: "prefix",
  [AffixSyntax.Suffix]: "suffix",
  [AffixSyntax.Names]: "'s",
  [AffixSyntax.From]: "from",
  [AffixSyntax.Of]: "of",
  [AffixSyntax.The]: "the"
};

export const RegisteredAffixesTable = ({ affixes }: Props) => {
  const textColor = useColorModeValue("gray.700", "white");

  const headers = [
    "Name",
    "Syntax",
    "Show Name Construction",
    "Registration date",
    "Status",
    "Actions"
  ];

  return (
    <Table variant="simple" color={textColor}>
      <Thead>
        <Tr my=".8rem" pl="0px" color="gray.400">
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
        {affixes.map((affix: RegisteredAffixListItem) => (
          <Tr>
            <Td py="25px">{affix.name}</Td>
            <Td>{syntaxDisplayName[affix.syntax]}</Td>
            <Td>
              <ShowNameText affix={affix} />
            </Td>
            <Td>
              {DateTime.fromJSDate(affix.registrationDate).toFormat(
                "yyyy/MM/dd"
              )}
            </Td>
          </Tr>
        ))}
      </Tbody>
    </Table>
  );
};
