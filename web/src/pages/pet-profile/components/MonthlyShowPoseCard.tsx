import { QuestionOutlineIcon, WarningTwoIcon } from "@chakra-ui/icons";
import {
  Box,
  Button,
  Card,
  CardBody,
  CardHeader,
  CardProps,
  Heading,
  Image,
  Stack,
  Tab,
  TabList,
  TabPanel,
  TabPanels,
  Tabs,
  Tooltip
} from "@chakra-ui/react";
import { DateTime } from "luxon";

export type Props = { poop?: boolean };

export const MonthlyShowPoseCard = ({ ...rest }: Props & CardProps) => {
  return (
    <Card variant="panel" {...rest}>
      <CardHeader>
        <Heading size="sm" display="flex" alignItems="center">
          Show Pictures for {DateTime.now().toFormat("LLLL")}
          <Tooltip
            label="Show pictures are automatically reset on the first day of each month.
          The picture must be not edited and have white background.
          Please keep in mind you may not reuse previously uploaded pictures."
          >
            <QuestionOutlineIcon ml="10px" h="16px" />
          </Tooltip>
        </Heading>
      </CardHeader>
      <CardBody>
        <Tabs variant="enclosed" colorScheme="teal" size="sm">
          <TabList>
            <Tab
              color="gray.500"
              fontWeight="bold"
              fontSize="12px"
              fontFamily="Segoe UI"
              style={{ textTransform: "uppercase" }}
            >
              Conformation <WarningTwoIcon color="red" ml="0.5em" />
            </Tab>
            <Tab
              isDisabled
              color="gray.500"
              fontWeight="bold"
              fontSize="12px"
              fontFamily="Segoe UI"
              style={{ textTransform: "uppercase" }}
            >
              Agility
            </Tab>
            <Tab
              isDisabled
              color="gray.500"
              fontWeight="bold"
              fontSize="12px"
              fontFamily="Segoe UI"
              style={{ textTransform: "uppercase" }}
            >
              Obedience
            </Tab>
          </TabList>
          <TabPanels>
            <TabPanel>
              <Box>
                <Stack
                  direction="column"
                  justifyContent="center"
                  alignItems="center"
                >
                  <Button colorScheme="teal" variant="link" size="sm">
                    Upload new picture
                  </Button>
                  <Image
                    //  src="http://i.imgur.com/rFNHVyy.png"
                    src="/images/catsilhouette.png"
                    objectFit="none"
                    minH="200px"
                  />
                </Stack>
              </Box>
            </TabPanel>
            <TabPanel></TabPanel>
            <TabPanel></TabPanel>
          </TabPanels>
        </Tabs>
      </CardBody>
    </Card>
  );
};
