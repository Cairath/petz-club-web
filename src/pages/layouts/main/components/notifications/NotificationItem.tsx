import { TimeIcon } from "@chakra-ui/icons";
import { Avatar, Flex, MenuItem, Text } from "@chakra-ui/react";
import { useColorModeValue } from "@chakra-ui/system";
import { DateTime } from "luxon";
import { Notification } from "../../../../../api/client";

export type Props = {
  notification: Notification;
};

export const NotificationItem = (props: Props) => {
  const { notification } = props;

  const navbarIcon = useColorModeValue("gray.500", "gray.200");
  const notificationColor = useColorModeValue("gray.700", "white");
  const notificationTime = DateTime.fromJSDate(notification.date);

  return (
    <>
      <MenuItem borderRadius="8px">
        <Avatar name={""} borderRadius="12px" me="16px" />
        <Flex flexDirection="column">
          <Text fontSize="14px" mb="5px" color={notificationColor}>
            {notification.text}
          </Text>
          <Flex alignItems="center">
            <TimeIcon color={navbarIcon} w="13px" h="13px" me="5px" />
            <Text fontSize="xs" lineHeight="100%" color={navbarIcon} mt="1px">
              {notificationTime.toRelative()}
            </Text>
          </Flex>
        </Flex>
      </MenuItem>
    </>
  );
};
