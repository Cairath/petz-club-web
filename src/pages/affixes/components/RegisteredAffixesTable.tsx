import { Table, useColorModeValue } from "@chakra-ui/react";
import { RegisteredAffixListItem } from "../../../api/client";
import { TableContent } from "./TableContent";

export type Props = {
  affixes: RegisteredAffixListItem[];
  pendingAffixes: RegisteredAffixListItem[];
};

export const RegisteredAffixesTable = ({ affixes, pendingAffixes }: Props) => {
  const textColor = useColorModeValue("gray.700", "white");

  const pendingHeaders = [
    "Name",
    "Syntax",
    "Show Name Construction",
    "",
    "Status",
    "Submission date",
    "Actions"
  ];

  const headers = [
    "Name",
    "Syntax",
    "Show Name Construction",
    "Pets",
    "Status",
    "Registration date",
    "Actions"
  ];

  return (
    <Table color={textColor}>
      {pendingAffixes.length > 0 && (
        <TableContent
          affixes={pendingAffixes}
          headers={pendingHeaders}
          type="pending"
        />
      )}
      <TableContent
        affixes={affixes}
        headers={headers}
        pt={pendingAffixes.length > 0 ? "40px" : undefined}
        type="registered"
      />
    </Table>
  );
};
