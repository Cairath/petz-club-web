import { Heading, Link, Text, useColorModeValue } from "@chakra-ui/react";
import { Link as ReactRouterLink } from "react-router-dom";
import { Age, PetProfileData } from "../../../api/client";
import { Space } from "../../../components/Space";

export type Props = {
  petProfileData: PetProfileData;
};

export const PetNameHeader = ({ petProfileData }: Props) => {
  const linkColor = useColorModeValue("teal.600", "teal.200");

  return (
    <Heading size="sm">
      GCh {petProfileData.showName} DSM CW'22
      <Text fontSize="sm" color="gray.400" fontWeight="bold">
        {petProfileData.age === Age.Junior && (
          <>
            {petProfileData.age}
            <Space />
          </>
        )}
        {petProfileData.sex}
        <Space />
        <Link
          as={ReactRouterLink}
          to={`/breed/${petProfileData.breedId}`}
          color={linkColor}
        >
          {petProfileData.breedName}
        </Link>
        , PBC. B/{petProfileData.pedigreeNumber}
      </Text>
    </Heading>
  );
};
