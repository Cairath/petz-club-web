import { Badge, Text } from "@chakra-ui/react";
import { createColumnHelper, SortingState } from "@tanstack/react-table";
import { useMemo } from "react";
import {
  Age,
  PetListItem,
  PetListItemPaged,
  PetStatus,
  Sex
} from "../../../api/client";
import { Pagination, PetListFilters, Sorting } from "../../../api/requests";
import { AffixLink } from "../../../components/AffixLink";
import { BreedLink } from "../../../components/BreedLink";
import { PetLink } from "../../../components/PetLink";
import { ServerSideTable } from "../../../components/ServerSideTable";
import { ColumnFilterType } from "../../../components/tables/types";

export type Props = {
  loading: boolean;
  pagedPetsList: PetListItemPaged | undefined;
  pagination: Pagination;
  onPaginationChange: (pagination: Pagination) => void;
  onSortingChange: (sorting: Sorting) => void;
  onColumnFiltersChange: (filters: PetListFilters) => void;
};

export const PetzListTable = ({
  loading,
  pagedPetsList,
  pagination,
  onPaginationChange,
  onSortingChange,
  onColumnFiltersChange
}: Props) => {
  const columnHelper = createColumnHelper<PetListItem>();

  const columns = useMemo(
    () => [
      columnHelper.accessor("showName", {
        header: "Show Name",
        cell: (props) => (
          <PetLink
            fontWeight="bold"
            petName={props.getValue()}
            petId={props.row.original.id}
          />
        ),
        meta: {
          filter: {
            type: ColumnFilterType.Text
          },
          width: "45%",
          minWidth: "200px"
        }
      }),
      columnHelper.accessor("breedName", {
        header: "Breed",
        cell: (props) => (
          <BreedLink
            breedName={props.getValue()}
            breedId={props.row.original.breedId}
          />
        ),
        meta: {
          filter: {
            type: ColumnFilterType.Text
          },
          width: "30%",
          minWidth: "200px"
        }
      }),
      columnHelper.accessor("age", {
        header: "Age",
        cell: (props) => <Text>{props.getValue()}</Text>,
        meta: {
          filter: {
            type: ColumnFilterType.Enum,
            enumValues: Age,
            isSearchable: false
          },
          width: "0%",
          minWidth: "200px"
        }
      }),
      columnHelper.accessor("sex", {
        header: "Sex",
        cell: (props) => (
          <Badge
            width="20px"
            textAlign={"center"}
            colorScheme={props.getValue() === Sex.Female ? "pink" : "blue"}
            variant="subtle"
            borderRadius="10px"
          >
            {props.getValue() === Sex.Female ? "F" : "M"}
          </Badge>
        ),
        meta: {
          filter: {
            type: ColumnFilterType.Enum,
            enumValues: Sex,
            isSearchable: false
          },
          width: "0%",
          minWidth: "200px"
        }
      }),
      columnHelper.accessor("affixName", {
        header: "Affix",
        cell: (props) => (
          <AffixLink
            affixName={props.getValue()}
            affixId={props.row.original.affixId}
          />
        ),
        meta: {
          filter: {
            type: ColumnFilterType.Text
          },
          width: "25%",
          minWidth: "200px"
        }
      }),
      columnHelper.accessor("status", {
        header: "Status",
        cell: (props) => (
          <Badge
            width="70px"
            textAlign={"center"}
            colorScheme={
              props.getValue() === PetStatus.Active ? "green" : "red"
            }
            variant="subtle"
          >
            {props.getValue()}
          </Badge>
        ),
        meta: {
          filter: {
            type: ColumnFilterType.Enum,
            enumValues: PetStatus,
            omitEnumValues: ["PendingRegistration"],
            isSearchable: false
          },
          width: "0%",
          minWidth: "150px"
        }
      })
    ],
    [columnHelper]
  );

  const initialSortingState: SortingState = [{ id: "showName", desc: false }];

  return (
    <ServerSideTable
      loading={loading || pagedPetsList === undefined}
      useColGroups={true}
      data={pagedPetsList?.items ?? []}
      itemTotalCount={pagedPetsList?.total ?? 0}
      columns={columns}
      initialSortingState={initialSortingState}
      pagination={pagination}
      onPaginationChange={onPaginationChange}
      onSortingChange={onSortingChange}
      onColumnFiltersChange={onColumnFiltersChange}
    />
  );
};
