import {
  Card,
  CardBody,
  CardHeader,
  CardProps,
  Heading,
  Icon,
  Link,
  Stack,
  Text,
  useColorModeValue
} from "@chakra-ui/react";
import { FaMars, FaVenus } from "react-icons/fa";
import { Link as ReactRouterLink } from "react-router-dom";
import { PetLink, Sex } from "../../../api/client";

export type Props = {
  offspring: PetLink[];
};

export const OffspringCard = ({ offspring, ...rest }: Props & CardProps) => {
  const linkColor = useColorModeValue("teal.600", "teal.200");

  return (
    <Card variant="panel" {...rest}>
      <CardHeader>
        <Heading size="sm">Offspring</Heading>
      </CardHeader>
      <CardBody>
        <Stack direction="column" spacing="0.5">
          {offspring.length === 0 && <Text>none</Text>}
          {offspring.map((pet: PetLink) => {
            return (
              <Text key={pet.id}>
                <Link
                  as={ReactRouterLink}
                  to={`/pet/${pet.id}`}
                  color={linkColor}
                >
                  {pet.showName}
                  <Icon
                    h="16px"
                    pt="2px"
                    mb="-2px"
                    ml="5px"
                    as={pet.sex === Sex.Male ? FaMars : FaVenus}
                  />
                </Link>
              </Text>
            );
          })}
        </Stack>
      </CardBody>
    </Card>
  );
};
