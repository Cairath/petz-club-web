import { createBrowserRouter, redirect } from "react-router-dom";
import "./App.css";
import { LoggedOut } from "./pages/auth/LoggedOut";
import { PasswordReset } from "./pages/auth/PasswordReset";
import { SignIn } from "./pages/auth/SignIn";
import { SignUp } from "./pages/auth/SignUp";
import { MainLayout } from "./pages/layouts/main/MainLayout";

import "@fontsource/roboto/400.css";
import "@fontsource/roboto/500.css";
import "@fontsource/roboto/700.css";
import { SignOut } from "./pages/auth/SignOut";
import { Dashboard } from "./pages/dashboard/Dashboard";
import { Affixes } from "./pages/affixes/Affixes";
import { Account } from "./pages/account/Account";
import { StaffDashboard } from "./pages/Staff/StaffDashboard";
import { AffixProfile } from "./pages/affix-profile/Account";

export const router = createBrowserRouter([
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
    path: "/staff",
    element: (
      <MainLayout>
        <StaffDashboard />
      </MainLayout>
    )
  },
  {
    path: "/affixes",
    element: (
      <MainLayout>
        <Affixes />
      </MainLayout>
    )
  },
  {
    path: "/account",
    element: (
      <MainLayout>
        <Account />
      </MainLayout>
    )
  },
  {
    path: "/affix/:affixId",
    element: (
      <MainLayout>
        <AffixProfile />
      </MainLayout>
    )
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
