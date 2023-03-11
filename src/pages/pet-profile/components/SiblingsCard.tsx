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
import { Sex, SiblingLink } from "../../../api/client";

export type Props = {
  siblings: SiblingLink[];
};

export const SiblingsCard = ({ siblings, ...rest }: Props & CardProps) => {
  const linkColor = useColorModeValue("teal.600", "teal.200");

  return (
    <Card variant="panel" {...rest}>
      <CardHeader>
        <Heading size="sm">Siblings</Heading>
      </CardHeader>
      <CardBody>
        <Stack direction="column" spacing="0.5">
          {siblings.length === 0 && <Text>none</Text>}
          {siblings.map((pet: SiblingLink) => {
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
                  <Text as="span" fontStyle="italic">
                    {pet.full ? "(full)" : "(half)"}
                  </Text>
                </Link>
              </Text>
            );
          })}
        </Stack>
      </CardBody>
    </Card>
  );
};
