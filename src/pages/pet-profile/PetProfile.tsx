import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import api from "../../api/api";
import { Pedigree, PetProfileData } from "../../api/client";
import { Header } from "../../components/Header";
import { PedigreeTable } from "./components/PedigreeTable";

export const PetProfile = () => {
  const { petId } = useParams();

  const [petProfileData, setPetProfileData] = useState<PetProfileData>({
    id: 0,
    showName: ""
  });

  const [pedigreeData, setPedigreeData] = useState<Pedigree>();

  useEffect(() => {
    if (petId === undefined) {
      return;
    }
    api
      .getPetProfile(+petId)
      .then((petProfileData: PetProfileData) =>
        setPetProfileData(petProfileData)
      );

    api
      .getPedigree(+petId, 5)
      .then((pedigreeData: Pedigree) => setPedigreeData(pedigreeData));
  }, [petId]);
  return (
    <>
      <Header title={petProfileData.showName} />
      {pedigreeData && (
        <PedigreeTable generations={5} pedigree={pedigreeData} />
      )}
    </>
  );
};
