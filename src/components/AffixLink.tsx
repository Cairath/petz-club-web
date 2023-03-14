import { Link, LinkProps, useColorModeValue } from "@chakra-ui/react";
import { Link as ReactRouterLink } from "react-router-dom";

export type Props = {
  affixName: string;
  affixId: number;
};
export const AffixLink = ({ affixName, affixId }: Props & LinkProps) => {
  const linkColor = useColorModeValue("teal.600", "teal.200");
  return (
    <Link as={ReactRouterLink} to={`/affix/${affixId}`} color={linkColor}>
      {affixName}
    </Link>
  );
};
