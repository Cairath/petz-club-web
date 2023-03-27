import { TriangleDownIcon, TriangleUpIcon } from "@chakra-ui/icons";
import {
  Box,
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
  ColumnMeta,
  flexRender,
  getCoreRowModel,
  getSortedRowModel,
  RowData,
  SortingState,
  useReactTable
} from "@tanstack/react-table";
import React, { useMemo, useState } from "react";
import { NoResultsRow } from "./NoResultsRow";
import { ColumnFilter } from "./tables/ColumnFilter";

export type Props<Data extends object> = {
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  columns: ColumnDef<Data, any>[];
  data: Data[];
  withTableTag?: boolean;
  tableColumnHeaderProps?: TableColumnHeaderProps;
  initialSortingState?: SortingState;
  useColGroups?: boolean;
};

export const BasicTable = <Data extends object>({
  data,
  columns,
  withTableTag = true,
  tableColumnHeaderProps,
  initialSortingState,
  useColGroups
}: Props<Data>) => {
  const [sorting, setSorting] = useState<SortingState>(
    initialSortingState ?? undefined!
  );

  //const [columnFilters, setColumnFilters] = useState<ColumnFiltersState>([]);
  //const [globalFilter, setGlobalFilter] = useState("");

  const table = useReactTable<Data>({
    columns,
    data,
    getCoreRowModel: getCoreRowModel(),
    onSortingChange: setSorting,
    getSortedRowModel: getSortedRowModel(),
    state: {
      sorting
      //   columnFilters,
      //   globalFilter
    }
    // filterFns: { fuzzy: {}},
    //onColumnFiltersChange: setColumnFilters,
    //onGlobalFilterChange: setGlobalFilter,
    // globalFilterFn: fuzzyFilter,
    // getFilteredRowModel: getFilteredRowModel(),
    //getPaginationRowModel: getPaginationRowModel()
    //  getFacetedRowModel: getFacetedRowModel(),
    //  getFacetedUniqueValues: getFacetedUniqueValues(),
    // getFacetedMinMaxValues: getFacetedMinMaxValues()
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
                  color="gray.400"
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
  );
};
