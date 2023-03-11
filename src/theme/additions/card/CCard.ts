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

const { defineMultiStyleConfig } = createMultiStyleConfigHelpers(
  cardAnatomy.keys
);

const cardTheme = defineMultiStyleConfig({
  variants: {
    defaultNoShadow: (props) => ({
      container: {
        boxShadow: "0px 3.5px 5.5px rgba(0, 0, 0, 0.02)",
        borderRadius: "15px",
        bg: mode("white", "gray.700")(props)
      }
    }),
    panel: (props) => ({
      container: {
        padding: "20px",
        boxShadow: "0px 3.5px 5.5px rgba(0, 0, 0, 0.02)",
        borderRadius: "15px",
        bg: mode("white", "gray.700")(props)
      },
      footer: {
        paddingBottom: 0
      },
      header: { paddingBottom: 0 }
    }),
    tablePanel: (props) => ({
      container: {
        boxShadow: "0px 3.5px 5.5px rgba(0, 0, 0, 0.02)",
        borderRadius: "15px",
        bg: mode("white", "gray.700")(props)
      },
      header: {
        paddingTop: "35px",
        paddingLeft: "40px",
        paddingRight: "40px",
        paddingBottom: "0px"
      }
    })
  }
});

export const CardComponent = {
  components: {
    Card: cardTheme
  }
};
