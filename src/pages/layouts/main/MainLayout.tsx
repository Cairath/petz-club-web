import { Box } from "@chakra-ui/react";
import React from "react";
import { AdminNavbar } from "./components/navbar/AdminNavbar";
import { Sidebar } from "./components/sidebar/Sidebar";

export type Props = {
  children?: React.ReactNode;
};

export const MainLayout = (props: Props) => {
  const { children } = props;

  return (
    <React.Fragment>
      <Sidebar />
      <RightContentBox>
        <ContentContainer>
          <AdminNavbar />
          {children}
        </ContentContainer>
      </RightContentBox>
    </React.Fragment>
  );
};

export const RightContentBox = (props: Props) => {
  const styles = {
    float: "right",
    maxWidth: "100%",
    overflow: "auto",
    position: "relative",
    maxHeight: "100%",
    transition: "all 0.33s cubic-bezier(0.685, 0.0473, 0.346, 1)",
    transitionDuration: ".2s, .2s, .35s",
    transitionProperty: "top, bottom, width",
    transitionTimingFunction: "linear, linear, ease",
    w: {
      base: "100%",
      xl: "calc(100% - 275px)"
    },
    minH: "100vh",
    ms: "auto",
    me: "auto",
    ps: "15px",
    pe: "15px"
  };

  return <Box __css={styles}>{props.children}</Box>;
};

export const ContentContainer = (props: Props) => {
  const styles = {
    p: "0px 15px",
    pb: "15px",
    minHeight: "calc(100vh - 25px)"
  };

  return <Box __css={styles}>{props.children}</Box>;
};
