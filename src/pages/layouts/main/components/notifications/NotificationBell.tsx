import { BellIcon } from "@chakra-ui/icons";
import {
  Flex,
  IconButton,
  Menu,
  MenuButton,
  MenuList,
  Portal
} from "@chakra-ui/react";
import { useContext, useMemo } from "react";
import { Notification } from "../../../../../api/client";
import { UserContext } from "../../../../../context/UserContext";
import { NotificationItem } from "./NotificationItem";

export type Props = {
  color: string;
};

export const NotificationBell = (props: Props) => {
  const { notifications } = useContext(UserContext);
  const sortedNotifications = useMemo(
    () =>
      [...notifications].sort(
        (a: Notification, b: Notification) =>
          b.date.getTime() - a.date.getTime()
      ),
    [notifications]
  );

  return (
    <Menu>
      <MenuButton as={IconButton} variant="ghost">
        <BellIcon color={props.color} w="18px" h="18px" />
      </MenuButton>
      <Portal>
        <MenuList p="16px 8px">
          <Flex flexDirection="column">
            {sortedNotifications.map((n: Notification) => {
              return <NotificationItem notification={n} />;
            })}
          </Flex>
        </MenuList>
      </Portal>
    </Menu>
  );
};
