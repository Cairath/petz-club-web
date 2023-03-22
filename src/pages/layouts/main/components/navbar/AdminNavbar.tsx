// Chakra Imports
import {
  Avatar,
  Box,
  Button,
  Flex,
  Menu,
  MenuButton,
  MenuItem,
  MenuList,
  Portal,
  Stack,
  Text,
  useColorMode,
  useColorModeValue,
  useDisclosure
} from "@chakra-ui/react";
import { useContext } from "react";
import { FaSignOutAlt, FaUser } from "react-icons/fa";
import { Link as ReactRouterLink } from "react-router-dom";
import api from "../../../../../api/api";
import { User, UserContext } from "../../../../../context/UserContext";
import { RegisterModal } from "../../../../auth/RegisterModal";
import { SignInModal } from "../../../../auth/SignInModal";
import { Notifications } from "../notifications/Notifications";
import { MobileSidebar } from "../sidebar/MobileSidebar";
import { ColorModeSwitch } from "./ColorModeSwitch";

export const AdminNavbar = () => {
  const { user, setUser } = useContext(UserContext);
  const { colorMode, setColorMode } = useColorMode();

  // todo cleanup
  const navbarPosition: "absolute" | "initial" = "initial";
  const navbarFilter = "none";
  const navbarShadow = "none";
  const navbarBg = "transparent";
  const navbarBorder = "transparent";
  const secondaryMargin = "15px";
  const paddingX = "15px";

  const navbarIcon = useColorModeValue("white", "gray.900");

  const signOut = async () => {
    api.signOut().then(() => setUser(null));
  };

  return (
    <Flex
      position={navbarPosition}
      boxShadow={navbarShadow}
      bg={navbarBg}
      borderColor={navbarBorder}
      filter={navbarFilter}
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
        <Box ms="auto" w={{ sm: "100%", md: "unset" }}>
          <Flex
            pe={{ sm: "0px" }}
            w={{ sm: "100%", md: "auto" }}
            alignItems="center"
            flexDirection="row"
          >
            <Stack direction="row" alignItems="center">
              <ColorModeSwitch
                color={navbarIcon}
                colorMode={colorMode}
                onClick={setColorMode}
              />
              <MobileSidebar />
              {user && <Notifications color={navbarIcon} />}
              <UserControl user={user} signOut={signOut} color={navbarIcon} />
            </Stack>
          </Flex>
        </Box>
      </Flex>
    </Flex>
  );
};

const UserControl = ({
  user,
  color,
  signOut
}: {
  user: User | null;
  color: string;
  signOut: () => void;
}) => {
  const {
    isOpen: isSignInOpen,
    onOpen: onSignInOpen,
    onClose: onSignInClose
  } = useDisclosure();

  const {
    isOpen: isRegistrationOpen,
    onOpen: onRegistrationOpen,
    onClose: onRegistrationClose
  } = useDisclosure();

  return (
    <Flex>
      {user != null ? ( //todo ===
        <Menu>
          <MenuButton>
            <Avatar size="sm" ms="2px" name={user.name}></Avatar>
          </MenuButton>
          <Portal>
            <MenuList minW="150px">
              <Flex flexDirection="column">
                <ReactRouterLink to="/account">
                  <MenuItem icon={<FaUser />}>Account</MenuItem>
                </ReactRouterLink>

                <MenuItem icon={<FaSignOutAlt />} onClick={() => signOut()}>
                  Sign Out
                </MenuItem>
              </Flex>
            </MenuList>
          </Portal>
        </Menu>
      ) : (
        <>
          <Button
            onClick={onSignInOpen}
            color={color}
            variant="ghost"
            aria-label="sign-in"
            rightIcon={<FaUser width="22px" height="22px" />}
          >
            <Text display={{ sm: "none", md: "flex" }}>Sign In</Text>
          </Button>
          <SignInModal
            iconColor={color}
            isOpen={isSignInOpen}
            onClose={onSignInClose}
            onRegistrationClicked={onRegistrationOpen}
          />
          <RegisterModal
            isOpen={isRegistrationOpen}
            onClose={onRegistrationClose}
            onSignInClicked={onSignInOpen}
          />
        </>
      )}
    </Flex>
  );
};
