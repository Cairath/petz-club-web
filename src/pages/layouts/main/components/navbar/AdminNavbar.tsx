// Chakra Imports
import {
  Box,
  Breadcrumb,
  BreadcrumbItem,
  BreadcrumbLink,
  Button,
  Flex,
  Text,
  useColorMode,
  useColorModeValue
} from "@chakra-ui/react";
import { useContext } from "react";
import { NavLink } from "react-router-dom";
import { ProfileIcon } from "../../../../../components/Icons/Icons";
import { UserContext } from "../../../../../context/UserContext";
import { MobileSidebar } from "../sidebar/MobileSidebar";
import { ColorModeSwitch } from "./ColorModeSwitch";
import { NotificationBell } from "../notifications/NotificationBell";

export const AdminNavbar = (props) => {
  const { variant, children, secondary, brandText, onOpen, ...rest } = props;

  const { user } = useContext(UserContext);
  const { colorMode, setColorMode } = useColorMode();

  // Here are all the props that may change depending on navbar's type or state.(secondary, variant, scrolled)
  let mainText = useColorModeValue("gray.700", "gray.200");
  let secondaryText = useColorModeValue("gray.400", "gray.200");
  let navbarPosition: "absolute" | "initial" = "initial";
  let navbarFilter = "none";
  let navbarBackdrop = "blur(21px)";
  let navbarShadow = "none";
  let navbarBg = "transparent"; //useColorModeValue("white", "gray.700");
  let navbarBorder = "transparent";
  let secondaryMargin = "15px";
  let paddingX = "15px";

  let mainTeal = useColorModeValue("teal.300", "teal.300");
  let inputBg = useColorModeValue("white", "gray.800");
  let navbarIcon = useColorModeValue("gray.500", "gray.200");
  let searchIcon = useColorModeValue("gray.700", "gray.200");

  return (
    <Flex
      position={navbarPosition}
      boxShadow={navbarShadow}
      bg={navbarBg}
      borderColor={navbarBorder}
      filter={navbarFilter}
      backdropFilter={navbarBackdrop}
      borderWidth="1.5px"
      borderStyle="solid"
      transitionDelay="0s, 0s, 0s, 0s"
      transitionDuration=" 0.25s, 0.25s, 0.25s, 0s"
      transition-property="box-shadow, background-color, filter, border"
      transitionTimingFunction="linear, linear, linear, linear"
      alignItems={{ xl: "center" }}
      borderRadius="16px"
      display="flex"
      minH="85px"
      justifyContent={{ xl: "center" }}
      lineHeight="25.6px"
      mx="auto"
      mb="4px"
      mt={secondaryMargin}
      pb="8px"
      px={{
        sm: paddingX,
        md: "30px"
      }}
      ps={{
        xl: "12px"
      }}
      pt="8px"
      w="100%"
    >
      <Flex
        w="100%"
        flexDirection={{
          sm: "column",
          md: "row"
        }}
        alignItems={{ xl: "center" }}
      >
        <Box mb={{ sm: "8px", md: "0px" }}>
          <Breadcrumb>
            <BreadcrumbItem color={mainText}>
              <BreadcrumbLink href="#" color={secondaryText}>
                something
              </BreadcrumbLink>
            </BreadcrumbItem>

            <BreadcrumbItem color={mainText}>
              <BreadcrumbLink href="#" color={mainText}>
                current location
              </BreadcrumbLink>
            </BreadcrumbItem>
          </Breadcrumb>
        </Box>
        <Box ms="auto" w={{ sm: "100%", md: "unset" }}>
          <Flex
            pe={{ sm: "0px" }}
            w={{ sm: "100%", md: "auto" }}
            alignItems="center"
            flexDirection="row"
          >
            {user ? (
              <Text me={{ sm: "2px", md: "16px" }}>
                Hello <b>{user.name}</b>!
              </Text>
            ) : (
              <NavLink to="/sign-in">
                <Button
                  ms="0px"
                  px="0px"
                  me={{ sm: "2px", md: "16px" }}
                  color={navbarIcon}
                  variant="transparent-with-icon"
                  rightIcon={
                    <ProfileIcon
                      color={navbarIcon}
                      w="22px"
                      h="22px"
                      me="0px"
                    />
                  }
                >
                  <Text display={{ sm: "none", md: "flex" }}>Sign In</Text>
                </Button>
              </NavLink>
            )}
            <NotificationBell color={navbarIcon} />
            <ColorModeSwitch
              color={navbarIcon}
              colorMode={colorMode}
              onClick={setColorMode}
            />
            <MobileSidebar />
          </Flex>
        </Box>
      </Flex>
    </Flex>
  );
};
