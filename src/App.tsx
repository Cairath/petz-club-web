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
import Dashboard from "./pages/dashboard/Dashboard";
import { UserProvider } from "./context/UserProvider";

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
        <Dashboard />
      </MainLayout>
    )
  },
  {
    path: "/lipsum",
    element: (
      <MainLayout>
        <div>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam rhoncus
          neque blandit, ultrices leo eget, convallis justo. Pellentesque amet
          convallis odio. Aliquam lobortis quam mauris, nec iaculis nulla tempus
          non. Aliquam commodo nec elit vel tincidunt. Aliquam venenatis
          porttitor justo, quis dapibus ipsum. Nullam in enim lectus. Ut
          tristique, lorem nec vestibulum posuere, velit quam ullamcorper nisl,
          nec auctor enim justo id est. Praesent sodales non massa vel
          imperdiet. Duis vehicula blandit nisl, sit amet rutrum nibh aliquam
          ut. Nulla ut maximus diam. Praesent ut nibh ac leo viverra sodales.
          Aliquam tincidunt aliquet ligula, eu rutrum risus posuere consectetur.
          Aliquam erat volutpat. Suspendisse scelerisque ligula eget nunc
          tincidunt fringilla. Nulla fermentum ultricies turpis, ac imperdiet
          est accumsan non. Pellentesque consequat aliquam tincidunt.
          Pellentesque pharetra tincidunt sapien ac fringilla. Donec efficitur
          efficitur purus, congue consequat libero feugiat sit amet. Sed vel
          mauris ipsum. Nunc id ipsum bibendum, luctus ipsum quis, pretium dui.
          Orci varius natoque penatibus et magnis dis parturient montes,
          nascetur ridiculus mus. Interdum et malesuada fames ac ante ipsum
          primis in faucibus. Duis sagittis varius imperdiet. Integer faucibus
          elit dolor, a tempus dolor varius ut. Phasellus non neque convallis,
          viverra urna sagittis, dapibus mauris. Nullam ut enim laoreet erat
          sagittis sollicitudin. Pellentesque habitant morbi tristique senectus
          et netus et malesuada fames ac turpis egestas. Quisque sodales commodo
          magna sed porta. Aenean venenatis ut lectus in congue. Vivamus iaculis
          viverra scelerisque. Donec sem ligula, vestibulum sed fringilla in,
          ultricies quis augue. Maecenas et elit quis magna vestibulum mattis
          quis nec diam. Aliquam placerat tempus dictum. Proin at massa et massa
          egestas vulputate ac eget leo. Etiam eu eros lacus. Suspendisse
          viverra tempor ante, at fringilla nunc tincidunt sit amet. Praesent
          pulvinar sapien eu risus volutpat interdum. Nulla massa sem, faucibus
          et feugiat sed, scelerisque quis lectus. Sed id massa fermentum,
          laoreet ex dictum, dapibus augue. Lorem ipsum dolor sit amet,
          consectetur adipiscing elit. Nam rhoncus neque blandit, ultrices leo
          eget, convallis justo. Pellentesque habitant morbi tristique senectus
          et netus et malesuada fames ac turpis egestas. Integer eu hendrerit
          ex, non dictum ex. Praesent convallis metus in nibh finibus, et
          posuere magna rutrum. Cras ac enim ut mi dictum scelerisque ut vitae
          est. Suspendisse tortor nisi, pharetra eu dui eget, condimentum
          rhoncus felis. Praesent in tincidunt urna. Maecenas auctor dui
          malesuada, tincidunt ligula vel, commodo odio. Aliquam at arcu justo.
          Cras sagittis volutpat felis, nec eleifend erat bibendum at. Sed nec
          mauris magna. Suspendisse sapien purus, ultrices a magna a, vestibulum
          laoreet lectus. Suspendisse potenti. Suspendisse tristique tortor sit
          amet bibendum pulvinar. Sed nisl ex, sollicitudin vel fermentum
          consectetur, tempor sit amet felis. Nulla a mauris iaculis, hendrerit
          diam vel, hendrerit nisl. Aenean tristique tortor eu lorem tempus
          feugiat. Sed augue lorem, tincidunt eu finibus eget, bibendum et
          ligula. Morbi vitae feugiat diam, sit amet convallis odio. Aliquam
          lobortis quam mauris, nec iaculis nulla tempus non. Aliquam commodo
          nec elit vel tincidunt. Aliquam venenatis porttitor justo, quis
          dapibus ipsum. Nullam in enim lectus. Ut tristique, lorem nec
          vestibulum posuere, velit quam ullamcorper nisl, nec auctor enim justo
          id est. Praesent sodales non massa vel imperdiet. Duis vehicula
          blandit nisl, sit amet rutrum nibh aliquam ut. Nulla ut maximus diam.
          Praesent ut nibh ac leo viverra sodales. Aliquam tincidunt aliquet
          ligula, eu rutrum risus posuere consectetur. Aliquam erat volutpat.
          Suspendisse scelerisque ligula eget nunc tincidunt fringilla. Nulla
          fermentum ultricies turpis, ac imperdiet est accumsan non.
          Pellentesque consequat aliquam tincidunt. Pellentesque pharetra
          tincidunt sapien ac fringilla. Donec efficitur efficitur purus, congue
          consequat libero feugiat sit amet. Sed vel mauris ipsum. Nunc id ipsum
          bibendum, luctus ipsum quis, pretium dui. Orci varius natoque
          penatibus et magnis dis parturient montes, nascetur ridiculus mus.
          Interdum et malesuada fames ac ante ipsum primis in faucibus. Duis
          sagittis varius imperdiet. Integer faucibus elit dolor, a tempus dolor
          varius ut. Phasellus non neque convallis, viverra urna sagittis,
          dapibus mauris. Nullam ut enim laoreet erat sagittis sollicitudin.
          Pellentesque habitant morbi tristique senectus et netus et malesuada
          fames ac turpis egestas. Quisque sodales commodo magna sed porta.
          Aenean venenatis ut lectus in congue. Vivamus iaculis viverra
          scelerisque. Donec sem ligula, vestibulum sed fringilla in, ultricies
          quis augue. Maecenas et elit quis magna vestibulum mattis quis nec
          diam. Aliquam placerat tempus dictum. Proin at massa et massa egestas
          vulputate ac eget leo. Etiam eu eros lacus. Suspendisse viverra tempor
          ante, at fringilla nunc tincidunt sit amet. Praesent pulvinar sapien
          eu risus volutpat interdum. Nulla massa sem, faucibus et feugiat sed,
          scelerisque quis lectus. Sed id massa fermentum, laoreet ex dictum,
          dapibus augue.
        </div>
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
