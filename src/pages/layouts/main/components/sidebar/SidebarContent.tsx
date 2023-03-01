import { Box, Link, Stack, Text, useColorModeValue } from "@chakra-ui/react";
import React from "react";
import { Link as ReactRouterLink } from "react-router-dom";
import { Separator } from "./Separator";
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
          <MenuLink to="/demo" entryName="Component demo" />
          <MenuLink to="/" entryName="Registrations" />
          <MenuLink to="/" entryName="Judging" />

          <CategoryHeader
            category="MY KENNELS & CATTERIES"
            color={activeColor}
          />
          <MenuLink to="/" entryName="Profile" />
          <MenuLink to="/" entryName="Petz" />
          <MenuLink to="/affixes" entryName="Affixes" />

          <CategoryHeader category="SHOWS" color={activeColor} />
          <MenuLink to="/" entryName="Shows" />
          <MenuLink to="/" entryName="Results" />
          <MenuLink to="/" entryName="Rules" />

          <CategoryHeader category="RESOURCES" color={activeColor} />
          <MenuLink to="/" entryName="Browse Registries" />
          <MenuLink to="/" entryName="Breeds" />
        </Box>
      </Stack>
    </React.Fragment>
  );
};

export type CategoryHeaderProps = {
  category: string;
  color: string;
};

export const CategoryHeader = (props: CategoryHeaderProps) => {
  return (
    <>
      <Text
        color={props.color}
        fontSize="0.9em"
        mx="auto"
        ps={{
          sm: "10px",
          xl: "16px"
        }}
        pt="12px"
        pb="5px"
      >
        {props.category}
      </Text>
      <Separator mb="6px" />
    </>
  );
};
