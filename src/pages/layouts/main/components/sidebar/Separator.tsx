import React from "react";
import { Flex, HTMLChakraProps } from "@chakra-ui/react";

export type Props = {
  children?: React.ReactNode;
} & HTMLChakraProps<"div">;

export const Separator = (props: Props) => {
  const { children, ...rest } = props;
  return (
    <Flex
      h="1px"
      w="100%"
      bg="linear-gradient(90deg, rgba(224, 225, 226, 0) 0%, #E0E1E2 49.52%, rgba(224, 225, 226, 0) 100%)"
      {...rest}
    >
      {children}
    </Flex>
  );
};
