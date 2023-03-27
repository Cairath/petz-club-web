import { ColorModeScript } from "@chakra-ui/system";
import React from "react";
import { createRoot } from "react-dom/client";
import App from "./App";
import reportWebVitals from "./reportWebVitals";

const root = createRoot(document.getElementById("root")!);

root.render(
  <React.StrictMode>
    <ColorModeScript />
    <App />
  </React.StrictMode>
);

reportWebVitals();
