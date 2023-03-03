import { Card, CardBody, Flex, Text } from "@chakra-ui/react";
import { useContext, useEffect, useState } from "react";
import api from "../../api/api";
import { OwnedAffixes } from "../../api/client";
import { Header } from "../../components/own/Header";
import { Space } from "../../components/own/Space";
import { UserContext } from "../../context/UserContext";
import { RegisteredAffixesTable } from "./components/RegisteredAffixesTable";

export const Affixes = () => {
  const { user } = useContext(UserContext);
  const [affixInfo, setAffixInfo] = useState<OwnedAffixes>({
    registered: [],
    pending: [],
    allowed: 0,
    owned: 0
  });

  useEffect(() => {
    getAffixInfo();
  }, [user]);

  const getAffixInfo = async () => {
    await api.getOwnedAffixes().then((affixes) => setAffixInfo(affixes));
  };

  const cancelRegistration = async (pendingAffixId: number) => {
    await api
      .cancelPendingAffixRegistration(pendingAffixId)
      .then(async () => await getAffixInfo());
  };

  return (
    <>
      <Header title="Affixes" />
      <Card variant="panel" mb="20px">
        <CardBody>
          <Flex flexDirection="column">
            <Text>
              You are currently using
              <Space />
              <Text fontWeight="bold" as="span">
                {affixInfo.owned} / {affixInfo.allowed}
              </Text>
              <Space />
              of your affix slots.
            </Text>
            <Text>
              Once registered, an affix can only be removed if there are no pets
              assigned to the affix.
            </Text>
          </Flex>
        </CardBody>
      </Card>
      <Card variant="tablePanel">
        <CardBody>
          <RegisteredAffixesTable
            affixes={affixInfo.registered}
            pendingAffixes={affixInfo.pending}
            cancelRegistration={cancelRegistration}
          />
        </CardBody>
      </Card>
    </>
  );
};
