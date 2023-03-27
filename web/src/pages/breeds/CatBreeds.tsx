import {
  Card,
  CardBody,
  CardHeader,
  Heading,
  SimpleGrid,
  Text
} from "@chakra-ui/react";
import { Header } from "../../components/Header";

export const CatBreeds = () => {
  const groups = [
    {
      id: 1,
      name: "Longhair"
    },
    {
      id: 2,
      name: "Semilonghair"
    },
    {
      id: 3,
      name: "Shorthair"
    },
    {
      id: 4,
      name: "Oriental & Siamese"
    },
    {
      id: 5,
      name: "Sentimental"
    }
  ];

  return (
    <>
      <Header title="Cat Breeds" />
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
