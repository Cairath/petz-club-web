import { Button, Flex, MenuList, Portal } from "@chakra-ui/react";
import { useMemo } from "react";
import { Notification } from "../../../../../api/client";
import { NotificationItem } from "./NotificationItem";

export type Props = {
  notifications: Notification[];
  unreadFilter: "all" | "unread";
  setUnreadFilter: (filter: "all" | "unread") => void;
  markAllAsRead: () => void;
  markOneAsRead: (id: number) => void;
  deleteNotification: (id: number) => void;
};

export const NotificationPortal = (props: Props) => {
  const {
    notifications,
    unreadFilter,
    setUnreadFilter,
    markAllAsRead,
    markOneAsRead,
    deleteNotification
  } = props;

  const notificationList = useMemo(
    () =>
      notifications.map((n: Notification) => {
        return (
          <NotificationItem
            key={`notification-${n.id}`}
            notification={n}
            markOneAsRead={markOneAsRead}
            deleteNotification={deleteNotification}
          />
        );
      }),
    [notifications, markOneAsRead, deleteNotification]
  );

  return (
    <Portal>
      <MenuList p="16px 8px" maxH="80vh" w="400px" maxW="90vw" overflowY="auto">
        <Flex flexDirection="column">
          <Flex flexDirection="row" mb="10px">
            <Button
              variant="outline"
              mx="10px"
              isActive={unreadFilter === "all"}
              onClick={() => setUnreadFilter("all")}
            >
              All
            </Button>
            <Button
              variant="outline"
              isActive={unreadFilter === "unread"}
              onClick={() => setUnreadFilter("unread")}
            >
              Unread
            </Button>
            <Button
              variant="ghost"
              ml="auto"
              onClick={(e) => {
                e.stopPropagation();
                markAllAsRead();
              }}
            >
              Mark all as read
            </Button>
          </Flex>
          {notificationList}
        </Flex>
      </MenuList>
    </Portal>
  );
};
