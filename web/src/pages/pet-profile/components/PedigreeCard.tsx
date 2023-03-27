import {
  Card,
  CardBody,
  CardHeader,
  CardProps,
  Heading,
  Text
} from "@chakra-ui/react";
import { Pedigree } from "../../../api/client";
import { PedigreeTable } from "./PedigreeTable";

export type Props = {
  pedigree: Pedigree;
};

export const PedigreeCard = ({ pedigree, ...rest }: Props & CardProps) => {
  return (
    <Card variant="panel" {...rest}>
      <CardHeader>
        <Heading size="sm">Pedigree</Heading>
        <Text fontSize="sm" color="gray.400" fontWeight="bold">
          showing 3 generations
        </Text>
      </CardHeader>
      <CardBody>
        <PedigreeTable generations={3} pedigree={pedigree} />
      </CardBody>
    </Card>
  );
};
