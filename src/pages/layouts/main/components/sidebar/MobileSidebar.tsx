/*eslint-disable*/
import { HamburgerIcon } from "@chakra-ui/icons";
// chakra imports
import {
  Box,
  Drawer,
  DrawerBody,
  DrawerCloseButton,
  DrawerContent,
  DrawerOverlay,
  Flex,
  IconButton,
  Link,
  Text,
  useColorModeValue,
  useDisclosure
} from "@chakra-ui/react";
import { Separator } from "./Separator";
import { PawIcon } from "../PawIcon";
import { SidebarContent } from "./SidebarContent";

export type Props = {};

export const MobileSidebar = (props: Props) => {
  const { isOpen, onOpen, onClose } = useDisclosure();
  const hamburgerColor = useColorModeValue("gray.500", "gray.200");

  return (
    <Flex display={{ sm: "flex", xl: "none" }} alignItems="center">
      <IconButton
        variant="ghost"
        color={hamburgerColor}
        onClick={onOpen}
        icon={<HamburgerIcon w="18px" h="18px" />}
        aria-label="mobileSidebar"
      />
      <Drawer isOpen={isOpen} onClose={onClose} placement="left">
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
