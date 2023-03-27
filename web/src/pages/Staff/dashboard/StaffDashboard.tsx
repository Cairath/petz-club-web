import {
  Card,
  CardBody,
  CardHeader,
  Grid,
  GridItem,
  Heading,
  Text
} from "@chakra-ui/react";
import { useEffect, useState } from "react";
import { FaCat, FaDog, FaPaw } from "react-icons/fa";
import api from "../../../api/api";
import { StaffDashboardSummary } from "../../../api/client";
import { Header } from "../../../components/Header";
import { RegistrationStat } from "./components/RegistrationStat";

export const StaffDashboard = () => {
  const [dashboardData, setDashboardData] = useState<StaffDashboardSummary>({
    pendingAffixRegistrations: 0,
    pendingCatRegistrations: 0,
    pendingDogRegistrations: 0
  });

  useEffect(() => {
    api
      .getStaffDashboard()
      .then((dashboardData: StaffDashboardSummary) =>
        setDashboardData(dashboardData)
      );
  }, []);

  return (
    <>
      <Header title="Staff Dashboard" />
      <Grid templateColumns="repeat(3, 1fr)" gap={6}>
        <GridItem>
          <RegistrationStat
            label="Pending Affix Registrations"
            value={dashboardData.pendingAffixRegistrations}
            icon={FaPaw}
            url="/staff/affix-registrations"
          />
        </GridItem>
        <GridItem>
          <RegistrationStat
            label="Pending Cat Registrations"
            value={dashboardData.pendingCatRegistrations}
            icon={FaCat}
            url="/"
          />
        </GridItem>
        <GridItem>
          <RegistrationStat
            label="Pending Dog Registrations"
            value={dashboardData.pendingDogRegistrations}
            icon={FaDog}
            url="/"
          />
        </GridItem>

        <GridItem colSpan={2}>
          <Card variant="panel">
            <CardHeader>
              <Heading size="md">Open Shows</Heading>
            </CardHeader>
            <CardBody>
              <Text>
                A fancy table with all running shows, their status (gathering
                entries, judging (with % status)), who's the judge
              </Text>
            </CardBody>
          </Card>
        </GridItem>
        <GridItem>
          <Card variant="panel">
            <CardHeader>
              <Heading size="md">My Shows</Heading>
            </CardHeader>
            <CardBody>
              <Text>List of own shows with links to them</Text>
            </CardBody>
          </Card>
        </GridItem>
      </Grid>
    </>
  );
};
