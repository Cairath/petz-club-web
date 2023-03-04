import { Card, CardBody } from "@chakra-ui/react";
import orderBy from "lodash-es/orderBy";
import { useEffect, useState } from "react";
import api from "../../../api/api";
import { PendingAffixRegistration } from "../../../api/client";
import { Header } from "../../../components/Header";
import { PendingAffixRegistrationsTable } from "./components/PendingAffixRegistrationsTable";

export const AffixRegistrations = () => {
  const [pendingAffixRegistrations, setPendingAffixRegistrations] = useState<
    PendingAffixRegistration[]
  >([]);

  useEffect(() => {
    api
      .getPendingAffixRegistrations()
      .then((pendingRegistrations: PendingAffixRegistration[]) => {
        pendingRegistrations.forEach((reg: PendingAffixRegistration) => {
          reg.similarNames = orderBy(
            reg.similarNames,
            (name) => name.similarityPercentage,
            "desc"
          );
        });

        setPendingAffixRegistrations(pendingRegistrations);
      });
  }, []);

  const acceptRegistration = async (pendingAffixId: number) => {
    //bla
  };

  const rejectRegistration = async (pendingAffixId: number, reason: string) => {
    //bla
  };

  return (
    <>
      <Header title="Affix Registrations" />
      <Card variant="tablePanel">
        <CardBody>
          <PendingAffixRegistrationsTable
            affixes={pendingAffixRegistrations}
            accept={acceptRegistration}
            reject={rejectRegistration}
          />
        </CardBody>
      </Card>
    </>
  );
};
