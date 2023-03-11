import { Box, Flex, Link, Text, useColorModeValue } from "@chakra-ui/react";
import { Pedigree, PedigreeEntry } from "../../../api/client";
import { Link as ReactRouterLink } from "react-router-dom";
export type Props = {
  pedigree: Pedigree;
  generations: number;
};

export const PedigreeTable = ({ pedigree, generations }: Props) => {
  return (
    <Flex direction="row" width="100%">
      {Array.from(Array(generations)).map((_, i) => {
        return (
          <Flex direction="column" key={i} width="100%">
            {Array.from(Array(Math.pow(2, i + 1))).map((_, j) => {
              return (
                <PedigreeEntryBox
                  entry={pedigree.entries[i][j]}
                  key={4 * i + j}
                />
              );
            })}
          </Flex>
        );
      })}
    </Flex>
  );
};

export type PedigreeEntryBoxProps = {
  entry: PedigreeEntry | undefined;
};
export const PedigreeEntryBox = ({ entry }: PedigreeEntryBoxProps) => {
  const linkColor = useColorModeValue("teal.600", "teal.200");

  return (
    <Box
      m="-0.5px"
      height="100%"
      border="1px"
      borderColor="gray.200"
      padding="2px"
      display="flex"
      flex="1"
      flexDirection="column"
      justifyContent="center"
      alignItems="center"
      textAlign="center"
    >
      {entry === null && (
        <>
          <Text m="0.75em">N/A</Text>
        </>
      )}
      {entry != null && (
        <>
          <Link as={ReactRouterLink} to={`/pet/${entry.id}`} color={linkColor}>
            <Text fontWeight="bold">{entry.showName}</Text>
          </Link>
          <Text>#{entry.pedigreeNumber}</Text>
        </>
      )}
    </Box>
  );
};
