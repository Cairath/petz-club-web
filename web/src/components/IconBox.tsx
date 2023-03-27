import React, { PropsWithChildren } from "react";
import { Flex, FlexProps } from "@chakra-ui/react";

export const IconBox = (props: PropsWithChildren & FlexProps) => {
  const { children, ...rest } = props;

  return (
    <Flex
      alignItems={"center"}
      justifyContent={"center"}
      borderRadius={"12px"}
      {...rest}
    >
      {children}
    </Flex>
  );
};
