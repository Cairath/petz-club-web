import { Box, Link, Stack, Text, useColorModeValue } from "@chakra-ui/react";
import React from "react";
import { Link as ReactRouterLink } from "react-router-dom";
import { Separator } from "../../../../../components/Separator/Separator";
import { MenuLink } from "./MenuLink";
import { PawIcon } from "../PawIcon";

export type Props = {
  mobile?: boolean;
};

export const SidebarContent = (props: Props) => {
  const activeColor = useColorModeValue("gray.700", "white");
  return (
    <React.Fragment>
      <Box pt={props.mobile ? "35px" : "25px"} mb="6px">
        <Link
          as={ReactRouterLink}
          to="/"
          display="flex"
          lineHeight="100%"
          mb="30px"
          fontWeight="bold"
          justifyContent="center"
          alignItems="center"
          fontSize="11px"
        >
          <PawIcon w="32px" h="32px" me="10px" />
          <Text fontSize="sm" mt="3px">
            PETZ BREEDERS CLUB
          </Text>
        </Link>
        <Separator />
      </Box>
      <Stack direction="column" mb="40px">
        <Box>
          <MenuLink to="/dashboard" entryName="Dashboard" />
          <MenuLink to="/lipsum" entryName="Lorem ipsum" />
          <Text
            color={activeColor}
            fontSize="1em"
            mx="auto"
            ps={{
              sm: "10px",
              xl: "16px"
            }}
            pt="12px"
            pb="5px"
          >
            CATEGORY
          </Text>
          <Separator mb="6px" />
          <MenuLink to="/dashboard" entryName="Dashboard" />
          <MenuLink to="/dashboard" entryName="Dashboard" />
          <MenuLink to="/lipsum" entryName="Lorem ipsum" />
          <MenuLink to="/lipsum" entryName="Lorem ipsum" />
          <Text
            color={activeColor}
            fontSize="1em"
            mx="auto"
            ps={{
              sm: "10px",
              xl: "16px"
            }}
            pt="12px"
            pb="5px"
          >
            CATEGORY 2
          </Text>
          <Separator mb="6px" />
          <MenuLink to="/dashboard" entryName="Dashboard" />
          <MenuLink to="/dashboard" entryName="Dashboard" />
          <MenuLink to="/dashboard" entryName="Dashboard" />
          <MenuLink to="/dashboard" entryName="Dashboard" />
          <MenuLink to="/dashboard" entryName="Dashboard" />
        </Box>
      </Stack>
    </React.Fragment>
  );
};
