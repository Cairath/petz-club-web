import {
  Card,
  CardBody,
  Flex,
  Table,
  Text,
  useColorModeValue
} from "@chakra-ui/react";
import { useContext, useEffect, useMemo, useState } from "react";
import api from "../../api/api";
import { OwnedAffixes } from "../../api/client";
import { Header } from "../../components/Header";
import { Space } from "../../components/Space";
import { UserContext } from "../../context/UserContext";
import { RegisteredAffixesTableContent } from "./components/RegisteredAffixesTableContent";

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

  const getAffixInfo = () => {
    api.getOwnedAffixes().then((affixes) => setAffixInfo(affixes));
  };

  const cancelRegistration = (pendingAffixId: number) => {
    api
      .cancelPendingAffixRegistration(pendingAffixId)
      .then(() => getAffixInfo());
  };

  const textColor = useColorModeValue("gray.700", "white");

  const pendingHeaders = [
    "Name",
    "Syntax",
    "Show Name Construction",
    "",
    "Status",
    "Submission date",
    "Actions"
  ];

  const headers = [
    "Name",
    "Syntax",
    "Show Name Construction",
    "Pets",
    "Status",
    "Registration date",
    "Actions"
  ];

  const showPending = useMemo(
    () => affixInfo.pending.length > 0,
    [affixInfo.pending]
  );

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
              assigned to it.
            </Text>
          </Flex>
        </CardBody>
      </Card>
      <Card variant="tablePanel">
        <CardBody>
          <Table color={textColor}>
            {showPending && (
              <RegisteredAffixesTableContent
                affixes={affixInfo.pending}
                headers={pendingHeaders}
                type="pending"
                cancelRegistration={cancelRegistration}
              />
            )}
            <RegisteredAffixesTableContent
              affixes={affixInfo.registered}
              headers={headers}
              pt={showPending ? "40px" : undefined}
              type="registered"
              cancelRegistration={cancelRegistration}
            />
          </Table>
        </CardBody>
      </Card>
    </>
  );
};
