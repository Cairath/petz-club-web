import { Box } from "@chakra-ui/react";
import { SidebarContent } from "./SidebarContent";

export const Sidebar = () => {
  return (
    <Box>
      <Box display={{ sm: "none", xl: "block" }} position="fixed">
        <Box
          w="260px"
          maxW="260px"
          maxH="100vh"
          overflowY="auto"
          ms={{
            sm: "16px"
          }}
          my={{
            sm: "16px"
          }}
          h="calc(100vh - 32px)"
          px="20px"
        >
          <SidebarContent />
        </Box>
      </Box>
    </Box>
  );
};
