import { IconButton, Menu, MenuButton } from "@chakra-ui/react";
import { useContext, useMemo, useState } from "react";
import api from "../../../../../api/api";
import { Notification } from "../../../../../api/client";
import { UserContext } from "../../../../../context/UserContext";
import { NotificationBellIcon } from "./NotificationBellIcon";
import { NotificationPortal } from "./NotificationPortal";

export type Props = {
  color: string;
};

export const Notifications = (props: Props) => {
  const { notifications, refreshNotifications } = useContext(UserContext);
  const [unreadFilter, setUnreadFilter] = useState<"all" | "unread">("all");

  const { color } = props;

  const sortedNotifications = useMemo(
    () =>
      [...notifications]
        .filter(
          (n: Notification) =>
            unreadFilter === "all" ||
            (unreadFilter === "unread" && n.read === false)
        )
        .sort(
          (a: Notification, b: Notification) =>
            b.date.getTime() - a.date.getTime()
        ),
    [notifications, unreadFilter]
  );

  const markAllAsRead = async () => {
    await api.markAllNotificationsAsRead().then(() => refreshNotifications());
  };

  const markOneAsRead = async (id: number) => {
    await api.markNotificationAsRead(id).then(() => refreshNotifications());
  };

  const deleteNotification = async (id: number) => {
    await api.deleteNotification(id).then(() => refreshNotifications());
  };

  const showUnreadDot = useMemo(() => {
    return sortedNotifications.find((n) => n.read === false) !== undefined;
  }, [sortedNotifications]);

  return (
    <Menu>
      <MenuButton
        as={IconButton}
        variant="ghost"
        icon={
          <NotificationBellIcon color={color} showUnreadDot={showUnreadDot} />
        }
      />
      <NotificationPortal
        notifications={sortedNotifications}
        unreadFilter={unreadFilter}
        setUnreadFilter={setUnreadFilter}
        markAllAsRead={markAllAsRead}
        markOneAsRead={markOneAsRead}
        deleteNotification={deleteNotification}
      />
    </Menu>
  );
};
