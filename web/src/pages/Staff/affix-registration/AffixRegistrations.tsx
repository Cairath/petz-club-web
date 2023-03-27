import { Card, CardBody } from "@chakra-ui/react";
import orderBy from "lodash-es/orderBy";
import { useCallback, useEffect, useState } from "react";
import api from "../../../api/api";
import { PendingAffixRegistration } from "../../../api/client";
import { Header } from "../../../components/Header";
import { PendingAffixRegistrationsTable } from "./components/PendingAffixRegistrationsTable";

export const AffixRegistrations = () => {
  const [pendingAffixRegistrations, setPendingAffixRegistrations] = useState<
    PendingAffixRegistration[]
  >([]);

  const getPendingAffixes = useCallback(async () => {
    const pendingRegistrations = await api.getPendingAffixRegistrations();

    pendingRegistrations.forEach((reg: PendingAffixRegistration) => {
      reg.similarNames = orderBy(
        reg.similarNames,
        (name) => name.similarityPercentage,
        "desc"
      );
    });

    setPendingAffixRegistrations(pendingRegistrations);
  }, []);

  const approveRegistration = useCallback(
    (pendingAffixId: number) => {
      api
        .approvePendingAffixRegistration(pendingAffixId)
        .then(() => getPendingAffixes());
    },
    [getPendingAffixes]
  );

  const rejectRegistration = useCallback(
    (pendingAffixId: number, reason: string) => {
      api
        .rejectPendingAffixRegistration({ id: pendingAffixId, reason })
        .then(() => getPendingAffixes());
    },
    [getPendingAffixes]
  );

  useEffect(() => {
    getPendingAffixes();
  }, [getPendingAffixes]);

  return (
    <>
      <Header title="Affix Registrations" />
      <Card variant="tablePanel">
        <CardBody>
          <PendingAffixRegistrationsTable
            affixes={pendingAffixRegistrations}
            approve={approveRegistration}
            reject={rejectRegistration}
          />
        </CardBody>
      </Card>
    </>
  );
};
