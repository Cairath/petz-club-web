import {
  Accordion,
  AccordionButton,
  AccordionItem,
  AccordionPanel,
  Drawer,
  Flex,
  SimpleGrid
} from "@chakra-ui/react";
import { useContext, useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import api from "../../api/api";
import { PetProfileData } from "../../api/client";
import { Header } from "../../components/Header";
import { UserContext } from "../../context/UserContext";
import { PageLoader } from "../layouts/main/components/PageLoader";
import { BioCard } from "./components/BioCard";
import { MonthlyShowPoseCard } from "./components/MonthlyShowPoseCard";
import { OffspringCard } from "./components/OffspringCard";
import { OwnerActionsCard } from "./components/OwnerActionsCard";
import { PedigreeCard } from "./components/PedigreeCard";
import { PetInfoCard } from "./components/PetInfoCard";
import { PetPhotoCard } from "./components/PetPhotoCard";
import { SiblingsCard } from "./components/SiblingsCard";

export const PetProfile = () => {
  const { user } = useContext(UserContext);
  const { petId } = useParams();

  const [loading, setLoading] = useState<boolean>(true);
  const [petProfileData, setPetProfileData] = useState<PetProfileData>();

  useEffect(() => {
    setLoading(true);

    if (petId === undefined) {
      return;
    }
    api.getPetProfile(+petId).then((petProfileData: PetProfileData) => {
      setPetProfileData(petProfileData);
      setLoading(false);
    });
  }, [petId]);

  return (
    <>
      <Header title={petProfileData?.showName} />
      <PageLoader loading={loading} />
      {!loading && petProfileData !== undefined && (
        <Flex direction="column">
          <SimpleGrid columns={{ md: 1, lg: 2, xl: 2, "2xl": 4 }} spacing={6}>
            <PetPhotoCard profileData={petProfileData} />
            <PetInfoCard profileData={petProfileData} />
            <OffspringCard offspring={petProfileData.offspring} />
            <SiblingsCard siblings={petProfileData.siblings} />
          </SimpleGrid>
          {user?.memberId === petProfileData.ownerId && (
            // <Accordion allowMultiple>
            //   <AccordionItem>
            //     <AccordionButton>Asssdd</AccordionButton>
            //     <AccordionPanel>
            <SimpleGrid
              columns={{ md: 1, lg: 2, xl: 2, "2xl": 2 }}
              spacing={6}
              mt="25px"
            >
              <OwnerActionsCard />
              <MonthlyShowPoseCard />
            </SimpleGrid>
          )}
          <PedigreeCard pedigree={petProfileData.pedigree} mt="25px" />
        </Flex>
      )}
    </>
  );
};
