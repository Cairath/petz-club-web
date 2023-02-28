import { CheckIcon, DeleteIcon, HamburgerIcon } from "@chakra-ui/icons";
import {
  Flex,
  IconButton,
  Menu,
  MenuButton,
  MenuItem,
  MenuList
} from "@chakra-ui/react";

export type Props = {
  visible: boolean;
  notificationId: number;
  markOneAsRead: (id: number) => void;
  deleteNotification: (id: number) => void;
};

export const NotificationItemMenu = (props: Props) => {
  const { visible, notificationId, markOneAsRead, deleteNotification } = props;
  return (
    <Menu placement="left">
      <MenuButton
        as={IconButton}
        variant="outline"
        ml="auto"
        aria-label="notification-menu"
        onClick={(e) => e.stopPropagation()}
        visibility={visible ? "visible" : "hidden"}
        icon={<HamburgerIcon />}
      />

      <MenuList p="6px 8px">
        <Flex flexDirection="column">
          <MenuItem
            icon={<CheckIcon />}
            borderRadius="8px"
            onClick={async (e) => {
              e.stopPropagation();
              markOneAsRead(notificationId);
            }}
          >
            Mark read
          </MenuItem>
          <MenuItem
            icon={<DeleteIcon />}
            borderRadius="8px"
            onClick={async (e) => {
              e.stopPropagation();
              deleteNotification(notificationId);
            }}
          >
            Delete notification
          </MenuItem>
        </Flex>
      </MenuList>
    </Menu>
  );
};
