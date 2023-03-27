import { Box, BoxProps, IconButton, Text, Tooltip } from "@chakra-ui/react";
import {
  FaAngleDoubleLeft,
  FaAngleDoubleRight,
  FaAngleLeft,
  FaAngleRight
} from "react-icons/fa";
import { Space } from "../Space";
import { PaginationPageButtons } from "./PaginationPageButtons";
import { Table } from "./types";

export type Props = {
  table: Table;
  itemTotalCount: number;
  size?: "sm" | "md" | "lg";
};

export const PaginationBox = ({
  table,
  itemTotalCount,
  size,
  ...rest
}: Props & BoxProps) => {
  return (
    <Box
      w="100%"
      display="flex"
      flexDir="row"
      alignItems="center"
      justifyContent="right"
      pr="20px"
      {...rest}
    >
      <Text>
        {table.getState().pagination.pageIndex *
          table.getState().pagination.pageSize +
          1}
        <Space />
        -
        <Space />
        {(table.getState().pagination.pageIndex + 1) *
          table.getState().pagination.pageSize}
        <Space />
        of {itemTotalCount}
      </Text>

      <Box ml="20px" display="flex" flexDir="row">
        <Tooltip label="First page">
          <IconButton
            size={size}
            variant="outline"
            aria-label="first-page"
            icon={<FaAngleDoubleLeft />}
            onClick={() => table.setPageIndex(0)}
            isDisabled={!table.getCanPreviousPage()}
            mx="2px"
          />
        </Tooltip>
        <Tooltip label="Previous page">
          <IconButton
            size={size}
            variant="outline"
            aria-label="prev-page"
            icon={<FaAngleLeft />}
            onClick={() => table.previousPage()}
            isDisabled={!table.getCanPreviousPage()}
            mx="2px"
          />
        </Tooltip>

        <PaginationPageButtons table={table} size={size} />

        <Tooltip label="Next page">
          <IconButton
            size={size}
            variant="outline"
            aria-label="next-page"
            icon={<FaAngleRight />}
            onClick={() => table.nextPage()}
            isDisabled={!table.getCanNextPage()}
            mx="2px"
          />
        </Tooltip>
        <Tooltip label="Last page">
          <IconButton
            size={size}
            variant="outline"
            aria-label="last-page"
            icon={<FaAngleDoubleRight />}
            onClick={() => table.setPageIndex(table.getPageCount() - 1)}
            isDisabled={!table.getCanNextPage()}
            mx="2px"
          />
        </Tooltip>
      </Box>
    </Box>
  );
};
