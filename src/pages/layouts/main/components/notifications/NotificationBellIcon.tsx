import { BellIcon } from "@chakra-ui/icons";
import { CircleIcon } from "./CircleIcon";

export type Props = {
  color: string;
  showUnreadDot: boolean;
};

export const NotificationBellIcon = (props: Props) => {
  const { color, showUnreadDot } = props;
  return (
    <>
      <BellIcon color={color} w="18px" h="18px" />
      <CircleIcon
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
