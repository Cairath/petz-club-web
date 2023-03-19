import { Heading, Text } from "@chakra-ui/react";
import { Age, PetProfileData } from "../../../api/client";
import { BreedLink } from "../../../components/BreedLink";
import { Space } from "../../../components/Space";

export type Props = {
  petProfileData: PetProfileData;
};

export const PetNameHeader = ({ petProfileData }: Props) => {
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
        <BreedLink
          breedId={petProfileData.breedId}
          breedName={petProfileData.breedName}
        />
        , PBC. B/{petProfileData.pedigreeNumber}
      </Text>
      <Text fontSize="sm" color="gray.400" fontWeight="bold" fontStyle="italic">
        {petProfileData.callName}
      </Text>
    </Heading>
  );
};
