import { Card, CardBody, SimpleGrid } from "@chakra-ui/react";
import { Link } from "react-router-dom";
import { Header } from "../../components/Header";

export const Breeds = () => {
  return (
    <>
      <Header title="Breeds" />
      <SimpleGrid columns={2} spacing={10}>
        <Card>
          <CardBody as={Link} to="/breeds/cats">
            Catz
          </CardBody>
        </Card>
        <Card>
          <CardBody as={Link} to="/breeds/dogs">
            Dogz
          </CardBody>
        </Card>
      </SimpleGrid>
    </>
  );
};
