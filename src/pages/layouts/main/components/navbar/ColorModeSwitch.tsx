import { MoonIcon, SunIcon } from "@chakra-ui/icons";
import { IconButton } from "@chakra-ui/react";
import { ColorMode, defineStyle } from "@chakra-ui/system";

export type Props = {
  colorMode: ColorMode;
  color: string;
  onClick: (value: ColorMode) => void;
};
export const ColorModeSwitch = (props: Props) => {
  const styles = defineStyle(() => {
    return {
      w: "18px",
      h: "18px",
      ms: { base: "16px", xl: "0px" },
      cursor: ""
    };
  });

  return (
    <IconButton
      {...styles}
      variant="ghost"
      onClick={() =>
        props.onClick(props.colorMode == "light" ? "dark" : "light")
      }
      icon={props.colorMode == "light" ? <MoonIcon /> : <SunIcon />}
      aria-label="colorModeSwitch"
    />
  );
};
