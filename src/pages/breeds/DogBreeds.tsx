import {
  Card,
  CardBody,
  CardHeader,
  Heading,
  SimpleGrid,
  Text
} from "@chakra-ui/react";
import { useEffect, useState } from "react";
import { Header } from "../../components/Header";
import api from "../../api/api";
import { BreedNameListItem, Species } from "../../api/client";
import { maxBy } from "lodash-es";

export const DogBreeds = () => {
  const [loading, setLoading] = useState<boolean>(false);
  const [breeds, setBreeds] = useState<BreedNameListItem[]>([]);

  useEffect(() => {
    setLoading(true);

    api.getBreedNamesList(Species.Dogz).then((breeds: BreedNameListItem[]) => {
      setBreeds(breeds);
      setLoading(false);
    });
  }, []);

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
              <Heading size="md">
                Group {group.id} (
                {breeds.filter((b) => b.group === group.id).length})
              </Heading>
              <Text fontSize="sm" color="gray.400" fontWeight="bold">
                {group.name}
              </Text>
            </CardHeader>
            <CardBody>
              <Group
                groupId={group.id}
                groupBreeds={breeds.filter((b) => b.group === group.id)}
              />
            </CardBody>
          </Card>
        ))}
      </SimpleGrid>
    </>
  );
};

const Group = ({
  groupBreeds,
  groupId
}: {
  groupBreeds: BreedNameListItem[];
  groupId: number;
}) => {
  const sections = maxBy(groupBreeds, (b) => b.section)?.section;
  return (
    <>
      {Array.from(Array(sections)).map((_, i) => {
        return (
          <>
            <Text fontWeight="bold" mt="10px">
              Section {i + 1}
            </Text>
            {groupBreeds
              .filter((b) => b.section === i + 1)
              .map((breed) => {
                return <Text>{breed.name}</Text>;
              })}
          </>
        );
      })}
    </>
  );
};
