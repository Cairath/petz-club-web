import { defineStyleConfig } from "@chakra-ui/system";
import { mode } from "@chakra-ui/theme-tools";
import { createMultiStyleConfigHelpers } from "@chakra-ui/styled-system";
import { cardAnatomy } from "@chakra-ui/anatomy";

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

const { definePartsStyle, defineMultiStyleConfig } =
  createMultiStyleConfigHelpers(cardAnatomy.keys);

const baseStyle = definePartsStyle({
  container: {
    boxShadow: "0px 3.5px 5.5px rgba(0, 0, 0, 0.02)",
    borderRadius: "15px"
  },
  header: {
    paddingTop: "25px",
    paddingBottom: "0px"
  }
});

const cardTheme = defineMultiStyleConfig({ baseStyle });

export const CardComponent = {
  components: {
    Card: cardTheme
  }
};
