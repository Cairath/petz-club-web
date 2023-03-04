import { TimeIcon } from "@chakra-ui/icons";
import { Flex, MenuItem, Text } from "@chakra-ui/react";
import { useColorModeValue } from "@chakra-ui/system";
import { DateTime } from "luxon";
import { useState } from "react";
import { Notification, NotificationType } from "../../../../../api/client";
import { IconBox } from "../../../../../components/IconBox";
import { PawIcon } from "../PawIcon";
import { NotificationItemMenu } from "./NotificationItemMenu";

export type Props = {
  notification: Notification;
  markOneAsRead: (id: number) => void;
  deleteNotification: (id: number) => void;
};

export const NotificationItem = (props: Props) => {
  const { notification, markOneAsRead, deleteNotification } = props;

  //todo clean up and rename this mess
  const navbarIcon = useColorModeValue("gray.500", "gray.200");
  const unreadColor = useColorModeValue("teal.500", "teal.200");
  const notificationColor = useColorModeValue("gray.700", "white");

  const notificationTime = DateTime.fromJSDate(notification.date);

  const iconBackgroundColor: Record<NotificationType, string> = {
    [NotificationType.Info]: useColorModeValue("white", "gray.700"),
    [NotificationType.Warning]: useColorModeValue("yellow.400", "yellow.400"),
    [NotificationType.Error]: useColorModeValue("red.400", "red.400"),
    [NotificationType.Success]: useColorModeValue("green.500", "green.500")
  };

  const iconColor: Record<NotificationType, string> = {
    [NotificationType.Info]: useColorModeValue("teal.500", "teal.200"),
    [NotificationType.Warning]: useColorModeValue("white", "white"),
    [NotificationType.Error]: useColorModeValue("white", "white"),
    [NotificationType.Success]: useColorModeValue("white", "white")
  };

  const [hovered, setHovered] = useState(false);

  return (
    <>
      <MenuItem
        as="div"
        cursor="pointer"
        borderRadius="8px"
        onClick={() => {
          /* todo */
        }}
        onMouseEnter={() => setHovered(true)}
        onMouseLeave={() => setHovered(false)}
      >
        <IconBox
          bg={iconBackgroundColor[notification.type]}
          style={{
            border:
              notification.type === NotificationType.Info
                ? "#319795 2px solid"
                : "none"
          }}
          color={iconColor[notification.type]}
          h="40px"
          w="40px"
          minW="40px"
          me="16px"
        >
          <PawIcon />
        </IconBox>
        <Flex flexDirection="column">
          <Text
            fontSize="14px"
            mb="5px"
            color={notificationColor}
            fontWeight={notification.read ? "normal" : "bold"}
          >
            {notification.text}
          </Text>
          <Flex alignItems="center" pb="2px">
            <TimeIcon color={navbarIcon} w="13px" h="13px" me="5px" />
            <Text
              fontSize="xs"
              lineHeight="100%"
              color={notification.read ? navbarIcon : unreadColor}
              mt="1px"
            >
              {notificationTime.toRelative()}
            </Text>
          </Flex>
        </Flex>
        <NotificationItemMenu
          visible={hovered}
          notificationId={notification.id}
          markOneAsRead={markOneAsRead}
          deleteNotification={deleteNotification}
        />
      </MenuItem>
    </>
  );
};
