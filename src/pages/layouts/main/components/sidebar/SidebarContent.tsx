import { Box, Link, Text, useColorModeValue } from "@chakra-ui/react";
import React, { useContext } from "react";
import { Link as ReactRouterLink } from "react-router-dom";
import { UserContext } from "../../../../../context/UserContext";
import { PawIcon } from "../PawIcon";
import { MenuLink } from "./MenuLink";
import { Separator } from "./Separator";

export type Props = {
  mobile?: boolean;
};

export const SidebarContent = (props: Props) => {
  const { user } = useContext(UserContext);
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
      <Box>
        {!!user && (
          <>
            <MenuLink to="/dashboard" entryName="Dashboard" />
            <MenuLink to="/staff/dashboard" entryName="Staff Dashboard" />
            <CategoryHeader
              category="MY KENNELS & CATTERIES"
              color={activeColor}
            />
            <MenuLink to="/" entryName="Profile" />
            <MenuLink to="/" entryName="Petz" />
            <MenuLink to="/affixes" entryName="Affixes" />
          </>
        )}

        <CategoryHeader category="SHOWS" color={activeColor} />
        <MenuLink to="/" entryName="Shows" />
        <MenuLink to="/" entryName="Results" />
        <MenuLink to="/" entryName="Rules" />

        <CategoryHeader category="RESOURCES" color={activeColor} />
        <MenuLink to="/" entryName="Browse Registries" />
        <MenuLink to="/breeds" entryName="Breeds" />
      </Box>
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
        fontWeight="bold"
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
