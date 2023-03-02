import { Table, useColorModeValue } from "@chakra-ui/react";
import { useMemo } from "react";
import { RegisteredAffixListItem } from "../../../api/client";
import { TableContent } from "./TableContent";

export type Props = {
  affixes: RegisteredAffixListItem[];
  pendingAffixes: RegisteredAffixListItem[];
  cancelRegistration: (pendingAffixId: number) => void;
};

export const RegisteredAffixesTable = ({
  affixes,
  pendingAffixes,
  cancelRegistration
}: Props) => {
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

  const showPending = useMemo(
    () => pendingAffixes.length > 0,
    [pendingAffixes]
  );

  return (
    <Table color={textColor}>
      {showPending && (
        <TableContent
          affixes={pendingAffixes}
          headers={pendingHeaders}
          type="pending"
          cancelRegistration={cancelRegistration}
        />
      )}
      <TableContent
        affixes={affixes}
        headers={headers}
        pt={showPending ? "40px" : undefined}
        type="registered"
        cancelRegistration={cancelRegistration}
      />
    </Table>
  );
};
