import { defineStyleConfig } from "@chakra-ui/system";
import { mode } from "@chakra-ui/theme-tools";

const CCard = defineStyleConfig({
  baseStyle: {
    p: "22px",
    display: "flex",
    flexDirection: "column",
    width: "100%",
    position: "relative",
    minWidth: "0px",
    wordWrap: "break-word",
    backgroundClip: "border-box",
    boxShadow: "0px 3.5px 5.5px rgba(0, 0, 0, 0.02)",
    borderRadius: "15px"
  },
  variants: {
    panel: (props) => ({
      bg: mode("white", "gray.700")(props)
    })
  },
  defaultProps: { variant: "panel" }
});

export const CCardComponent = {
  components: {
    CCard: CCard
  }
};
