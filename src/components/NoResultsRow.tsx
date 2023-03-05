import { Td, Text, Tr } from "@chakra-ui/react";

export type Props = {
  colSpan: number;
};

export const NoResultsRow = ({ colSpan }: Props) => {
  return (
    <Tr>
      <Td colSpan={colSpan}>
        <Text fontWeight="bold" textAlign="center">
          No results found
        </Text>
      </Td>
    </Tr>
  );
};
