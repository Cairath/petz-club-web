import { TriangleDownIcon, TriangleUpIcon } from "@chakra-ui/icons";
import {
  Box,
  Button,
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
  getFacetedRowModel,
  getFacetedUniqueValues,
  PaginationState,
  RowData,
  SortingState,
  Updater,
  useReactTable
} from "@tanstack/react-table";
import React, { useMemo, useState } from "react";
import { Pagination, SortDirection, Sorting } from "../api/requests";
import { NoResultsRow } from "./NoResultsRow";
import { ColumnFilter } from "./tables/ColumnFilter";

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
      console.log(vals);

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
    getCoreRowModel: getCoreRowModel(),
    getFacetedRowModel: getFacetedRowModel(),
    getFacetedUniqueValues: getFacetedUniqueValues(),
    // getSortedRowModel: getSortedRowModel(),

    state: {
      sorting,
      pagination: internalPaginationState
    },
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

  const layout = useMemo(() => {
    const layout = withTableTag
      ? useColGroups
        ? { layout: "fixed" }
        : {}
      : {};
    return layout;
  }, [withTableTag, useColGroups]);

  return (
    <>
      <TopElement {...layout}>
        {useColGroups
          ? table.getHeaderGroups().map((headerGroup) => {
              return (
                <colgroup>
                  {headerGroup.headers.map((header) => {
                    const width = header.column.columnDef.meta?.width;
                    const minWidth = header.column.columnDef.meta?.minWidth;

                    const minWidthStyle = minWidth
                      ? { minWidth: minWidth }
                      : undefined;

                    const widthStyle = width ? { width: width } : undefined;

                    return (
                      <col
                        id={header.id}
                        span={1}
                        width={width}
                        style={{ ...minWidthStyle, ...widthStyle }}
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
              {headerGroup.headers.map((header) => {
                const meta: ColumnMeta<RowData, unknown> | undefined =
                  header.column.columnDef.meta;

                return (
                  <Th
                    key={header.id}
                    //   color="gray.400"
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
                    </Flex>
                  </Th>
                );
              })}
            </Tr>
          ))}
        </Thead>
        <Tbody>
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
      <div className="h-2">
        <div className="flex items-center gap-2">
          <Button
            className="border rounded p-1"
            onClick={() => table.setPageIndex(0)}
            disabled={!table.getCanPreviousPage()}
          >
            {"<<"}
          </Button>
          <Button
            className="border rounded p-1"
            onClick={() => table.previousPage()}
            disabled={!table.getCanPreviousPage()}
          >
            {"<"}
          </Button>
          <Button
            className="border rounded p-1"
            onClick={() => table.nextPage()}
            disabled={!table.getCanNextPage()}
          >
            {">"}
          </Button>
          <Button
            className="border rounded p-1"
            onClick={() => table.setPageIndex(table.getPageCount() - 1)}
            disabled={!table.getCanNextPage()}
          >
            {">>"}
          </Button>
          <span className="flex items-center gap-1">
            <div>Page</div>
            <strong>
              {table.getState().pagination.pageIndex + 1} of{" "}
              {table.getPageCount()}
            </strong>
          </span>
          <span className="flex items-center gap-1">
            | Go to page:
            <input
              type="number"
              defaultValue={table.getState().pagination.pageIndex + 1}
              onChange={(e) => {
                const page = e.target.value ? Number(e.target.value) - 1 : 0;
                table.setPageIndex(page);
              }}
              className="border p-1 rounded w-16"
            />
          </span>
          <select
            value={table.getState().pagination.pageSize}
            onChange={(e) => {
              table.setPageSize(Number(e.target.value));
            }}
          >
            {[10, 20, 30, 40, 50].map((pageSize) => (
              <option key={pageSize} value={pageSize}>
                Show {pageSize}
              </option>
            ))}
          </select>
        </div>
        <div>{table.getRowModel().rows.length} Rows</div>
        <div>
          Showing{" "}
          {table.getState().pagination.pageIndex *
            table.getState().pagination.pageSize +
            1}{" "}
          -{" "}
          {(table.getState().pagination.pageIndex + 1) *
            table.getState().pagination.pageSize}{" "}
          of {itemTotalCount}
        </div>
      </div>
    </>
  );
};
