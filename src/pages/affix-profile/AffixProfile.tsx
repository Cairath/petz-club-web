import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import api from "../../api/api";
import { AffixProfileData } from "../../api/client";
import { Header } from "../../components/Header";

export const AffixProfile = () => {
  const { affixId } = useParams();

  const [affixProfileData, setAffixProfileData] = useState<AffixProfileData>({
    id: 0,
    ownerId: 0,
    name: "",
    ownerName: ""
  });

  useEffect(() => {
    if (affixId === undefined) {
      return;
    }
    api
      .getAffixProfile(+affixId)
      .then((affixProfileData: AffixProfileData) =>
        setAffixProfileData(affixProfileData)
      );
  }, [affixId]);

  return <Header title={affixProfileData.name} />;
};
