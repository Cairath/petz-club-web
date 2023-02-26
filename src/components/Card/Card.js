import { Box, useStyleConfig } from "@chakra-ui/react";

function CCard(props) {
  const { children, variant, ...rest } = props;
  const styles = useStyleConfig("CCard", { variant});
  return (
    <Box __css={styles} {...rest}>
      {children}
    </Box>
  );
}

export default CCard;
