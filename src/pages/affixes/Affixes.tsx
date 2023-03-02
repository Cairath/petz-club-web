import {
  Button,
  Card,
  CardBody,
  CardHeader,
  Flex,
  Heading,
  Text
} from "@chakra-ui/react";
import { useContext, useEffect, useState } from "react";
import api from "../../api/api";
import { OwnedAffixes } from "../../api/client";
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
      <Card variant="tablePanel">
        <CardHeader>
          <Flex direction="row" alignItems="center" mr="50px">
            <Heading size="md">Registered Affixes</Heading>
            <Button
              ml="auto"
              colorScheme="teal"
              isDisabled={affixInfo.owned > affixInfo.allowed}
            >
              <Text>New affix</Text>
            </Button>
          </Flex>
        </CardHeader>
        <CardBody>
          <Flex px="20px" pb="20px" flexDirection="column">
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
