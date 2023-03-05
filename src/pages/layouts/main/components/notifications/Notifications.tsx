import {
  IconButton,
  IconButtonProps,
  Menu,
  MenuButton
} from "@chakra-ui/react";
import { useCallback, useContext, useMemo, useState } from "react";
import api from "../../../../../api/api";
import { Notification } from "../../../../../api/client";
import { UserContext } from "../../../../../context/UserContext";
import { NotificationBellIcon } from "./NotificationBellIcon";
import { NotificationPortal } from "./NotificationPortal";

export type Props = {
  color: string;
};

export const Notifications = ({
  color,
  ...rest
}: Props & Omit<IconButtonProps, "aria-label">) => {
  const { notifications, refreshNotifications } = useContext(UserContext);
  const [unreadFilter, setUnreadFilter] = useState<"all" | "unread">("all");

  const markAllAsRead = useCallback(
    () => api.markAllNotificationsAsRead().then(() => refreshNotifications()),
    [refreshNotifications]
  );

  const markOneAsRead = useCallback(
    (id: number) =>
      api.markNotificationAsRead(id).then(() => refreshNotifications()),
    [refreshNotifications]
  );

  const deleteNotification = useCallback(
    (id: number) =>
      api.deleteNotification(id).then(() => refreshNotifications()),
    [refreshNotifications]
  );

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
        {...rest}
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
