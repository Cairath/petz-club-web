import { ChakraProvider } from "@chakra-ui/react";
import { RouterProvider } from "react-router-dom";
import "./App.css";

import "@fontsource/roboto/400.css";
import "@fontsource/roboto/500.css";
import "@fontsource/roboto/700.css";
import { UserProvider } from "./context/UserProvider";
import { router } from "./router";
import theme from "./theme/theme.js";
import "react-toastify/dist/ReactToastify.css";
import { ToastContainer } from "react-toastify";

const App = () => {
  return (
    <UserProvider>
      <ChakraProvider theme={theme}>
        <ToastContainer position="top-right" />
        <RouterProvider router={router} />
      </ChakraProvider>
    </UserProvider>
  );
};

export default App;
