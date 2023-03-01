import { Card, CardBody, CardHeader, Heading } from "@chakra-ui/react";
import { useContext, useEffect, useState } from "react";
import api from "../../api/api";
import { RegisteredAffixListItem } from "../../api/client";
import { UserContext } from "../../context/UserContext";
import { RegisteredAffixesTable } from "./components/RegisteredAffixesTable";

export const Affixes = () => {
  const { user } = useContext(UserContext);
  const [registeredAffixes, setRegisteredAffixes] = useState<
    RegisteredAffixListItem[]
  >([]);

  useEffect(() => {
    api.getOwnedAffixes().then((affixes) => setRegisteredAffixes(affixes));
  }, [user]);

  return (
    <>
      <Card>
        <CardHeader>
          <Heading size="md">Your registered affixes</Heading>
        </CardHeader>
        <CardBody>
          <RegisteredAffixesTable affixes={registeredAffixes} />
        </CardBody>
      </Card>
    </>
  );
};
