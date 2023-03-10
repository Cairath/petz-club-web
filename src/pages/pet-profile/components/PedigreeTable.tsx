import { Box, Flex, Link } from "@chakra-ui/react";
import { Pedigree } from "../../../api/client";
import { Link as ReactRouterLink } from "react-router-dom";
export type Props = {
  pedigree: Pedigree;
  generations: number;
};

export const PedigreeTable = ({ pedigree, generations }: Props) => {
  return (
    <Flex direction="row">
      {Array.from(Array(generations)).map((_, i) => {
        return (
          <Flex direction="column" key={i}>
            {Array.from(Array(Math.pow(2, i + 1))).map((_, j) => {
              return (
                <Box
                  m="3px"
                  height="100%"
                  key={`entry-${i}-${j}`}
                  backgroundColor={j % 2 === 0 ? "blue.100" : "pink.100"}
                >
                  <Link
                    as={ReactRouterLink}
                    to={`/pet/${pedigree.entries[i][j]?.id}`}
                  >
                    {pedigree.entries[i][j]?.id}{" "}
                    {pedigree.entries[i][j]?.showName ?? "N/A"}
                  </Link>
                </Box>
              );
            })}
          </Flex>
        );
      })}
    </Flex>
  );
};
