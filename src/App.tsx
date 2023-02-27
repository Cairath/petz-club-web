import "./App.css";
import {
  createBrowserRouter,
  redirect,
  RouterProvider
} from "react-router-dom";
import { MainLayout } from "./pages/layouts/main/MainLayout";
import { SignUp } from "./pages/auth/SignUp";
import { PasswordReset } from "./pages/auth/PasswordReset";
import { LoggedOut } from "./pages/auth/LoggedOut";
import { SignIn } from "./pages/auth/SignIn";
import { ChakraProvider } from "@chakra-ui/react";

import theme from "./theme/theme.js";
import "@fontsource/roboto/400.css";
import "@fontsource/roboto/500.css";
import "@fontsource/roboto/700.css";
import { SignOut } from "./pages/auth/SignOut";
import Demo from "./pages/demo/Demo";
import { UserProvider } from "./context/UserProvider";
import { Dashboard } from "./pages/dashboard/Dashboard";

const router = createBrowserRouter([
  {
    path: "/",
    element: <MainLayout />,
    loader: () => redirect("/dashboard")
  },
  {
    path: "/dashboard",
    element: (
      <MainLayout>
        <Dashboard />
      </MainLayout>
    )
  },
  {
    path: "/demo",
    element: (
      <MainLayout>
        <Demo />
      </MainLayout>
    )
  },
  {
    path: "/lipsum",
    element: <MainLayout></MainLayout>
  },
  { path: "/sign-in", element: <SignIn /> },
  { path: "/sign-up", element: <SignUp /> },
  { path: "/sign-out", element: <SignOut /> },
  { path: "/password-reset", element: <PasswordReset /> },
  { path: "/logged-out", element: <LoggedOut /> },
  {
    path: "*",
    element: <div>wild</div>
  }
]);

const App = () => {
  return (
    <UserProvider>
      <ChakraProvider theme={theme}>
        <RouterProvider router={router} />
      </ChakraProvider>
    </UserProvider>
  );
};

export default App;
