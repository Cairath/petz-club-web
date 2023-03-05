import {
  Card,
  CardBody,
  CardHeader,
  Heading,
  SimpleGrid,
  Text
} from "@chakra-ui/react";
import { Header } from "../../components/Header";

export const DogBreeds = () => {
  const groups = [
    {
      id: 1,
      name: "Sheepdogs and Cattledogs (except Swiss Cattledogs)"
    },
    {
      id: 2,
      name: "Pinscher and Schnauzer - Molossoid and Swiss Mountain and Cattledogs"
    },
    {
      id: 3,
      name: "Terriers"
    },
    {
      id: 4,
      name: "Dachshunds"
    },
    {
      id: 5,
      name: "Spitz and primitive types"
    },
    {
      id: 6,
      name: "Scent hounds and related breeds"
    },
    {
      id: 7,
      name: "Pointing Dogs"
    },
    {
      id: 8,
      name: "Retrievers - Flushing Dogs - Water Dogs"
    },
    {
      id: 9,
      name: "Companion and Toy Dogs"
    },
    {
      id: 10,
      name: "Sighthounds"
    }
  ];

  return (
    <>
      <Header title="Dog Breeds" />
      <SimpleGrid columns={{ sm: 1, md: 2, xl: 2, "2xl": 5 }} spacing={10}>
        {groups.map((group) => (
          <Card variant="panel">
            <CardHeader>
              <Heading size="md">Group {group.id}</Heading>
              <Text fontSize="sm" color="gray.400" fontWeight="bold">
                {group.name}
              </Text>
            </CardHeader>
            <CardBody></CardBody>
          </Card>
        ))}
      </SimpleGrid>
    </>
  );
};
