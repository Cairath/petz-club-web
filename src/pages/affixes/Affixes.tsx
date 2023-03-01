import {
  Button,
  Card,
  CardBody,
  CardHeader,
  Flex,
  Heading,
  Text
} from "@chakra-ui/react";
import { useContext, useEffect, useMemo, useState } from "react";
import api from "../../api/api";
import { RegisteredAffixListItem } from "../../api/client";
import { Space } from "../../components/own/Space";
import { UserContext } from "../../context/UserContext";
import { RegisteredAffixesTable } from "./components/RegisteredAffixesTable";

export const Affixes = () => {
  const { user } = useContext(UserContext);
  const [registeredAffixes, setRegisteredAffixes] = useState<
    RegisteredAffixListItem[]
  >([]);

  const [pendingAffixes, setPendingAffixes] = useState<
    RegisteredAffixListItem[]
  >([]);

  const permittedAffixes = 50;

  useEffect(() => {
    api.getOwnedAffixes().then((affixes) => setRegisteredAffixes(affixes));
    api
      .getOwnedPendingAffixes()
      .then((pendingAffixes) => setPendingAffixes(pendingAffixes));
  }, [user]);

  const affixCount = useMemo(
    () => registeredAffixes.length + pendingAffixes.length,
    [registeredAffixes, pendingAffixes]
  );

  return (
    <>
      <Card variant="tablePanel">
        <CardHeader>
          <Flex direction="row" alignItems="center" mr="50px">
            <Heading size="md">Registered Affixes</Heading>
            <Button
              ml="auto"
              colorScheme="teal"
              isDisabled={affixCount > permittedAffixes}
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
                {affixCount} / {permittedAffixes}
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
            affixes={registeredAffixes}
            pendingAffixes={pendingAffixes}
          />
        </CardBody>
      </Card>
    </>
  );
};
