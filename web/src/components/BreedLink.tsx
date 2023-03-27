import { Link, LinkProps, useColorModeValue } from "@chakra-ui/react";
import { Link as ReactRouterLink } from "react-router-dom";

export type Props = {
  breedName: string;
  breedId: number;
};
export const BreedLink = ({ breedName, breedId }: Props & LinkProps) => {
  const linkColor = useColorModeValue("teal.600", "teal.200");
  return (
    <Link as={ReactRouterLink} to={`/breed/${breedId}`} color={linkColor}>
      {breedName}
    </Link>
  );
};
