import {
  Card,
  CardBody,
  CardHeader,
  CardProps,
  Link,
  Stack,
  Text,
  useColorModeValue
} from "@chakra-ui/react";
import { DateTime } from "luxon";
import { Link as ReactRouterLink } from "react-router-dom";
import { PetProfileData } from "../../../api/client";
import { Space } from "../../../components/Space";
import { gameVersionDisplay, petStatusDisplayData } from "../../../utils";
import { PetNameHeader } from "./PetNameHeader";

export type Props = {
  profileData: PetProfileData;
};

export const PetInfoCard = ({ profileData, ...rest }: Props & CardProps) => {
  const linkColor = useColorModeValue("teal.600", "teal.200");

  return (
    <Card variant="panel" {...rest}>
      <CardHeader>
        <PetNameHeader petProfileData={profileData} />
      </CardHeader>
      <CardBody>
        <Stack direction="column" spacing="0.5">
          <Text fontWeight="bold"></Text>
          <Text>
            Registered on
            <Space />
            {DateTime.fromJSDate(profileData.registrationDate).toLocaleString({
              month: "long",
              day: "numeric",
              year: "numeric"
            })}
          </Text>
          <Text>
            Owned by
            <Space />
            <Link
              as={ReactRouterLink}
              to={`/member/${profileData.breederId}`}
              color={linkColor}
            >
              {profileData.breederName}
            </Link>
          </Text>
          <Text>
            Bred by <Space />
            <Link
              as={ReactRouterLink}
              to={`/member/${profileData.breederId}`}
              color={linkColor}
            >
              {profileData.breederName}
            </Link>
            <Space />(
            <Link
              as={ReactRouterLink}
              to={`/affix/${profileData.affixId}`}
              color={linkColor}
            >
              {profileData.affixName}
            </Link>
            )
          </Text>
          <Text>
            File:
            <Space />
            <Link as={ReactRouterLink} to={`/}`} color={linkColor}>
              CK Border Collie
            </Link>
            <Space />
            for
            <Space />
            {gameVersionDisplay[profileData.gameVersion]}
          </Text>
          <Text>
            Status:
            <Space />
            {petStatusDisplayData[profileData.status].name}
          </Text>
        </Stack>
      </CardBody>
    </Card>
  );
};
