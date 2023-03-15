import { Link, LinkProps, useColorModeValue } from "@chakra-ui/react";
import { Link as ReactRouterLink } from "react-router-dom";

export type Props = {
  petName: string;
  petId: number;
};

export const PetLink = ({ petName, petId, ...rest }: Props & LinkProps) => {
  const linkColor = useColorModeValue("teal.600", "teal.200");
  return (
    <Link as={ReactRouterLink} to={`/pet/${petId}`} color={linkColor} {...rest}>
      {petName}
    </Link>
  );
};
