import { Button, Flex, Text } from "@chakra-ui/react";
import { useColorModeValue } from "@chakra-ui/system";
import { NavLink, To } from "react-router-dom";
import { IconBox } from "../../../../../components/IconBox";
import { PawIcon } from "../PawIcon";

export type MenuLinkProps = {
  to: To;
  entryName: string;
};

export const MenuLink = (props: MenuLinkProps) => {
  const activeBg = useColorModeValue("white", "gray.700");
  const inactiveBg = useColorModeValue("white", "gray.700");
  const activeColor = useColorModeValue("gray.700", "white");
  const inactiveColor = useColorModeValue("gray.400", "gray.400");

  const { to, entryName } = props;

  return (
    <NavLink
      to={to}
      children={({ isActive }) => (
        <Button
          boxSize="initial"
          justifyContent="flex-start"
          alignItems="center"
          bg={isActive ? activeBg : "transparent"}
          my={{
            xl: "6px"
          }}
          mx={{
            xl: "auto"
          }}
          ps={{
            sm: "10px",
            xl: "16px"
          }}
          py="12px"
          borderRadius="15px"
          w="100%"
          _active={{
            bg: "inherit",
            transform: "none",
            borderColor: "transparent"
          }}
          _focus={{
            boxShadow: "none"
          }}
        >
          <Flex>
            <IconBox
              bg={isActive ? "teal.300" : inactiveBg}
              color={isActive ? "white" : "teal.300"}
              h="30px"
              w="30px"
              me="12px"
            >
              <PawIcon />
            </IconBox>
            <Text
              color={isActive ? activeColor : inactiveColor}
              my="auto"
              fontSize="sm"
              pt="3px"
            >
              {entryName}
            </Text>
          </Flex>
        </Button>
      )}
    />
  );
};
