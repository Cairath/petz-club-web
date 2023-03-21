import { createBrowserRouter, redirect } from "react-router-dom";
import "./App.css";
import { MainLayout } from "./pages/layouts/main/MainLayout";

import "@fontsource/roboto/400.css";
import "@fontsource/roboto/500.css";
import "@fontsource/roboto/700.css";
import { Account } from "./pages/account/Account";
import { AffixProfile } from "./pages/affix-profile/AffixProfile";
import { Affixes } from "./pages/affixes/Affixes";
import { Breeds } from "./pages/breeds/Breeds";
import { CatBreeds } from "./pages/breeds/CatBreeds";
import { DogBreeds } from "./pages/breeds/DogBreeds";
import { Dashboard } from "./pages/dashboard/Dashboard";
import { Landing } from "./pages/landing/Landing";
import { PetProfile } from "./pages/pet-profile/PetProfile";
import { Petz } from "./pages/petz/Petz";
import { AffixRegistrations } from "./pages/Staff/affix-registration/AffixRegistrations";
import { StaffDashboard } from "./pages/Staff/dashboard/StaffDashboard";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <MainLayout />,
    loader: () => redirect("/dashboard")
  },
  {
    path: "/landing",
    element: (
      <MainLayout>
        <Landing />
      </MainLayout>
    )
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
    path: "/staff/dashboard",
    element: (
      <MainLayout>
        <StaffDashboard />
      </MainLayout>
    )
  },
  {
    path: "/staff/affix-registrations",
    element: (
      <MainLayout>
        <AffixRegistrations />
      </MainLayout>
    )
  },
  {
    path: "/member/petz",
    element: (
      <MainLayout>
        <Petz />
      </MainLayout>
    )
  },
  {
    path: "/member/affixes",
    element: (
      <MainLayout>
        <Affixes />
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
  {
    path: "/pet/:petId",
    element: (
      <MainLayout>
        <PetProfile />
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
    path: "/breeds",
    element: (
      <MainLayout>
        <Breeds />
      </MainLayout>
    )
  },
  {
    path: "/breeds/cats",
    element: (
      <MainLayout>
        <CatBreeds />
      </MainLayout>
    )
  },
  {
    path: "/breeds/dogs",
    element: (
      <MainLayout>
        <DogBreeds />
      </MainLayout>
    )
  },
  {
    path: "*",
    element: <div>wild</div>
  }
]);
