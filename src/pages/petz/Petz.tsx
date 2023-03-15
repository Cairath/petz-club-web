import { Card, CardBody, Flex, Text } from "@chakra-ui/react";
import { useContext, useEffect, useState } from "react";
import { PetListItemPaged } from "../../api/client";
import {
  getPetsList,
  Pagination,
  PetListFilters,
  SortDirection,
  Sorting
} from "../../api/requests";
import { Header } from "../../components/Header";
import { UserContext } from "../../context/UserContext";
import { PetzListTable } from "./components/PetzListTable";

export const Petz = () => {
  const { user } = useContext(UserContext);

  const [loading, setLoading] = useState<boolean>(false);
  const [petList, setPetList] = useState<PetListItemPaged>();
  const [filters, setFilters] = useState<PetListFilters>();
  const [pagination, setPagination] = useState<Pagination>({
    page: 1,
    pageSize: 10
  });
  const [sorting, setSorting] = useState<Sorting>({
    sortDirection: SortDirection.Asc,
    sortField: "ShowName"
  });

  useEffect(() => {
    setLoading(true);

    if (user?.id === undefined) {
      return;
    }

    getPetsList({ ...filters, ownerId: user.id }, pagination, sorting).then(
      (petList: PetListItemPaged) => {
        setPetList(petList);
        setLoading(false);
      }
    );
  }, [filters, pagination, sorting, user]);

  return (
    <>
      <Header title="My Petz" />
      <Card variant="panel" mb="20px">
        <CardBody>
          <Flex flexDirection="column">
            <Text mb="2em">
              Affix refers to your Kennel / Cattery name added to pets' show
              names. When you register 1st generation pets or offspring born in
              your Kennel / Cattery, you will be asked to choose from a list of
              affixes you own.
            </Text>
          </Flex>
        </CardBody>
      </Card>
      <Card variant="tablePanel">
        <CardBody>
          <PetzListTable
            loading={loading}
            pagedPetsList={petList}
            pagination={pagination}
            onPaginationChange={setPagination}
            onSortingChange={setSorting}
            onColumnFiltersChange={setFilters}
          />
        </CardBody>
      </Card>
    </>
  );
};
