import { TriangleDownIcon, TriangleUpIcon } from "@chakra-ui/icons";
import {
  Box,
  CircularProgress,
  Flex,
  Table,
  TableColumnHeaderProps,
  Tbody,
  Td,
  Text,
  Th,
  Thead,
  Tr
} from "@chakra-ui/react";
import {
  ColumnDef,
  ColumnFiltersState,
  ColumnMeta,
  flexRender,
  getCoreRowModel,
  PaginationState,
  RowData,
  SortingState,
  Updater,
  useReactTable
} from "@tanstack/react-table";
import React, { useMemo, useState } from "react";
import { Pagination, SortDirection, Sorting } from "../api/requests";
import { PageLoader } from "../pages/layouts/main/components/PageLoader";
import { NoResultsRow } from "./NoResultsRow";
import { ColumnFilter } from "./tables/ColumnFilter";
import { PaginationBox } from "./tables/PaginationBox";

export type Props<Data extends object> = {
  loading: boolean;
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  columns: ColumnDef<Data, any>[];
  data: Data[];
  withTableTag?: boolean;
  tableColumnHeaderProps?: TableColumnHeaderProps;
  initialSortingState?: SortingState;
  useColGroups?: boolean;

  itemTotalCount: number;
  pagination: Pagination;
  onPaginationChange: (pagination: Pagination) => void;
  onSortingChange: (sorting: Sorting) => void;
  onColumnFiltersChange: (filters: Record<string, unknown>) => void;
};

export const ServerSideTable = <Data extends object>({
  loading,
  data,
  columns,
  withTableTag = true,
  tableColumnHeaderProps,
  initialSortingState,
  useColGroups,
  itemTotalCount,
  pagination,
  onPaginationChange,
  onSortingChange,
  onColumnFiltersChange
}: Props<Data>) => {
  const [sorting, setSorting] = useState<SortingState>(
    initialSortingState ?? undefined!
  );

  const [columnFilters, setColumnFilters] = useState<ColumnFiltersState>([]);

  const sortingChanged = (updater: Updater<SortingState>) => {
    if (typeof updater === "function") {
      const vals = updater(sorting);

      if (vals.length > 0) {
        const sortField = vals[0].id;
        const pascalCaseField =
          sortField.charAt(0).toUpperCase() + sortField.slice(1);

        onSortingChange({
          sortField: pascalCaseField,
          sortDirection:
            vals[0].desc === true ? SortDirection.Desc : SortDirection.Asc
        });
      } else {
        onSortingChange({});
      }

      setSorting(vals);
    }
  };

  const internalPaginationState = useMemo(
    () => ({
      pageIndex: pagination.page - 1,
      pageSize: pagination.pageSize
    }),
    [pagination]
  );

  const paginationChanged = (
    paginationStateUpdater: Updater<PaginationState>
  ) => {
    if (typeof paginationStateUpdater === "function") {
      const vals = paginationStateUpdater({
        pageSize: internalPaginationState.pageSize,
        pageIndex: internalPaginationState.pageIndex
      });

      onPaginationChange({ pageSize: vals.pageSize, page: vals.pageIndex + 1 });
    }
  };

  const columnFiltersChanged = (
    columnFiltersStateUpdater: Updater<ColumnFiltersState>
  ) => {
    if (typeof columnFiltersStateUpdater === "function") {
      const vals = columnFiltersStateUpdater(columnFilters);

      const filterRecord = vals.reduce<Record<string, unknown>>(
        (prev, columnFilter) => {
          prev[columnFilter.id] = columnFilter.value;
          return prev;
        },
        {}
      );

      onColumnFiltersChange(filterRecord);
      setColumnFilters(vals);
    }
  };

  const table = useReactTable<Data>({
    columns,
    data,
    state: {
      sorting,
      pagination: internalPaginationState
    },

    getCoreRowModel: getCoreRowModel(),

    /* pagination */
    manualPagination: true,
    onPaginationChange: paginationChanged,
    pageCount: Math.ceil(itemTotalCount / internalPaginationState.pageSize),

    /* sorting */
    manualSorting: true,
    onSortingChange: sortingChanged,

    manualFiltering: true,
    onColumnFiltersChange: columnFiltersChanged
  });

  const TopElement = useMemo(() => {
    return withTableTag ? Table : React.Fragment;
  }, [withTableTag]);

  return (
    <>
      <PaginationBox table={table} itemTotalCount={itemTotalCount} size="sm" />
      <TopElement>
        {useColGroups
          ? table.getHeaderGroups().map((headerGroup) => {
              return (
                <colgroup key={headerGroup.id}>
                  {headerGroup.headers.map((header) => {
                    const width = header.column.columnDef.meta?.width;
                    const minWidth = header.column.columnDef.meta?.minWidth;

                    const minWidthStyle = minWidth
                      ? { minWidth: minWidth }
                      : undefined;

                    return (
                      <col
                        id={header.id}
                        key={header.id}
                        span={1}
                        width={width}
                        style={{
                          ...minWidthStyle
                        }}
                      />
                    );
                  })}
                </colgroup>
              );
            })
          : null}
        <Thead>
          {table.getHeaderGroups().map((headerGroup) => (
            <Tr key={headerGroup.id}>
              {headerGroup.headers.map((header, i) => {
                const meta: ColumnMeta<RowData, unknown> | undefined =
                  header.column.columnDef.meta;

                return (
                  <Th
                    key={header.id}
                    //color="gray.400"
                    cursor={header.column.getCanSort() ? "pointer" : undefined}
                    {...tableColumnHeaderProps}
                  >
                    <Flex direction="column" justifyContent="top" height="100%">
                      <Box onClick={header.column.getToggleSortingHandler()}>
                        {flexRender(
                          header.column.columnDef.header,
                          header.getContext()
                        )}
                        <Text as="span" pl="4px" position="absolute">
                          {header.column.getIsSorted() ? (
                            header.column.getIsSorted() === "desc" ? (
                              <TriangleDownIcon aria-label="sorted descending" />
                            ) : (
                              <TriangleUpIcon aria-label="sorted ascending" />
                            )
                          ) : null}
                        </Text>
                      </Box>
                      {header.column.getCanFilter() ? (
                        <ColumnFilter
                          filterOptions={meta?.filter}
                          filterProps={{
                            column: header.column,
                            table: table
                          }}
                        />
                      ) : null}
                      {loading && i === 0 && (
                        <Box
                          display="flex"
                          justifyContent="center"
                          position="absolute"
                          top="54%"
                          left="50%"
                          transform="translateX(-50%)"
                        >
                          <CircularProgress isIndeterminate color="teal" />
                        </Box>
                      )}
                    </Flex>
                  </Th>
                );
              })}
            </Tr>
          ))}
        </Thead>

        <Tbody style={{ filter: loading ? "blur(5px)" : undefined }}>
          {table.getRowModel().rows.map((row) => (
            <Tr key={row.id}>
              {row.getVisibleCells().map((cell) => {
                return (
                  <Td key={cell.id}>
                    {flexRender(cell.column.columnDef.cell, cell.getContext())}
                  </Td>
                );
              })}
            </Tr>
          ))}
          {table.getRowModel().rows.length === 0 && (
            <NoResultsRow colSpan={columns.length} />
          )}
        </Tbody>
      </TopElement>
      <PaginationBox
        table={table}
        itemTotalCount={itemTotalCount}
        size="sm"
        mt="10px"
      />
    </>
  );
};
