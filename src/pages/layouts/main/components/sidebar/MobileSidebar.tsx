/*eslint-disable*/
import { HamburgerIcon } from "@chakra-ui/icons";
// chakra imports
import {
  Box,
  Button,
  Drawer,
  DrawerBody,
  DrawerCloseButton,
  DrawerContent,
  DrawerOverlay,
  Flex,
  IconButton,
  Link,
  Stack,
  Text,
  useColorModeValue,
  useDisclosure
} from "@chakra-ui/react";
import React from "react";
import {
  NavLink,
  useLocation,
  Link as ReactRouterLink
} from "react-router-dom";
import { Separator } from "../../../../../components/Separator/Separator";
import { MenuLink } from "./MenuLink";
import { PawIcon } from "../PawIcon";
import { SidebarContent } from "./SidebarContent";

export type Props = {};

export const MobileSidebar = (props: Props) => {
  const [state, setState] = React.useState({});
  const mainPanel = React.useRef();

  let hamburgerColor = useColorModeValue("gray.500", "gray.200");

  var brand = (
    <Box pt={"35px"} mb="8px">
      <Link
        href={`${process.env.PUBLIC_URL}/#/`}
        target="_blank"
        display="flex"
        lineHeight="100%"
        mb="30px"
        fontWeight="bold"
        justifyContent="center"
        alignItems="center"
        fontSize="11px"
      >
        <PawIcon w="32px" h="32px" me="10px" />
        <Text fontSize="sm" mt="3px">
          Petz Breeders Club
        </Text>
      </Link>
      <Separator />
    </Box>
  );

  // SIDEBAR
  const { isOpen, onOpen, onClose } = useDisclosure();
  const btnRef = React.useRef();
  const activeColor = useColorModeValue("gray.700", "white");
  return (
    <Flex
      display={{ sm: "flex", xl: "none" }}
      ref={mainPanel}
      alignItems="center"
    >
      <IconButton
        ref={btnRef}
        variant="ghost"
        color={hamburgerColor}
        onClick={onOpen}
        icon={<HamburgerIcon w="18px" h="18px" />}
        aria-label="mobileSidebar"
      />
      <Drawer
        isOpen={isOpen}
        onClose={onClose}
        placement="left"
        finalFocusRef={btnRef}
      >
        <DrawerOverlay />
        <DrawerContent
          w="250px"
          maxW="250px"
          ms={{
            sm: "16px"
          }}
          my={{
            sm: "16px"
          }}
          borderRadius="16px"
        >
          <DrawerCloseButton
            _focus={{ boxShadow: "none" }}
            _hover={{ boxShadow: "none" }}
          />
          <DrawerBody maxW="250px" px="1rem">
            <SidebarContent mobile />
          </DrawerBody>
        </DrawerContent>
      </Drawer>
    </Flex>
  );
};
