import { Box, Button, Card, CardBody, Flex, Text } from "@chakra-ui/react";
import { Space } from "components/Space";
import { useContext, useEffect, useMemo, useState } from "react";
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
import { Link as ReactRouterLink } from "react-router-dom";

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

  const canRegisterMore = useMemo(() => true, []);

  return (
    <>
      <Header title="My Petz" />
      <Card variant="panel" mb="20px">
        <CardBody>
          <Flex flexDirection="column">
            <Text>
              You currently have
              <Space />
              <Text fontWeight="bold" as="span">
                {/* {affixInfo.owned} / {affixInfo.allowed} */}
              </Text>
              <Space />
              pending pet registrations.
            </Text>
            <Text>
              Once registered, a pet can only be removed if it has no offspring
              and was never entered into a show.
            </Text>
            <Box mt="2em">
              <ReactRouterLink to="/member/petz/register">
                <Button
                  px="2em"
                  bg="teal.300"
                  color="white"
                  _hover={{
                    bg: "teal.200"
                  }}
                  _active={{
                    bg: "teal.400"
                  }}
                  isDisabled={!canRegisterMore}
                >
                  Register a new pet
                </Button>
              </ReactRouterLink>
            </Box>
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
