import { BellIcon } from "@chakra-ui/icons";
import { Icon } from "@chakra-ui/react";
import { FaCircle } from "react-icons/fa";

export type Props = {
  color: string;
  showUnreadDot: boolean;
};

export const NotificationBellIcon = (props: Props) => {
  const { color, showUnreadDot } = props;
  return (
    <>
      <BellIcon color={color} w="18px" h="18px" />
      <Icon
        as={FaCircle}
        visibility={showUnreadDot ? "visible" : "collapse"}
        w="12px"
        h="12px"
        color="red.500"
        position="absolute"
        bottom="5px"
        right="5px"
      />
    </>
  );
};
