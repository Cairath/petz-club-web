import { Box, Button, IconButton, Tooltip } from "@chakra-ui/react";
import { FaEllipsisH } from "react-icons/fa";
import { Table } from "./types";

export type Props = {
  table: Table;
  size?: "sm" | "md" | "lg";
};

export const PaginationPageButtons = ({ table, size }: Props) => {
  const page = table.getState().pagination.pageIndex + 1;
  const pageCount = table.getPageCount();

  let pages: number[] = [];
  if (page < 5) {
    pages = [1, 2, 3, 4, 5].slice(0, Math.min(pageCount, 5));
  }

  if (page >= 5 && page < pageCount - 4) {
    pages = [page - 2, page - 1, page, page + 1, page + 2];
  }

  if (page >= 5 && page >= pageCount - 4) {
    pages = [
      pageCount - 4,
      pageCount - 3,
      pageCount - 2,
      pageCount - 1,
      pageCount
    ];
  }

  return (
    <Box>
      {page >= 5 && (page - 3 !== 1 || page >= pageCount - 4) && (
        <PageButton table={table} page={1} size={size} key={1} />
      )}

      {page >= 5 &&
        (page - 3 !== 1 || (page >= pageCount - 4 && page - 5 !== 1)) && (
          <Tooltip label="Previous 5 pages">
            <IconButton
              size={size}
              variant="outline"
              aria-label="first-page"
              icon={<FaEllipsisH />}
              onClick={() =>
                table.setPageIndex(table.getState().pagination.pageIndex - 5)
              }
              isDisabled={!table.getCanPreviousPage()}
              mx="2px"
            />
          </Tooltip>
        )}

      {pages.map((page) => (
        <PageButton table={table} page={page} size={size} key={page} />
      ))}

      {pageCount > 6 && page < pageCount - 4 && (
        <>
          <Tooltip label="Next 5 pages">
            <IconButton
              size={size}
              variant="outline"
              aria-label="first-page"
              icon={<FaEllipsisH />}
              onClick={() =>
                table.setPageIndex(table.getState().pagination.pageIndex + 5)
              }
              isDisabled={!table.getCanNextPage()}
              mx="2px"
            />
          </Tooltip>
          <PageButton
            table={table}
            page={pageCount}
            size={size}
            key={pageCount}
          />
        </>
      )}
    </Box>
  );
};

type PageButtonProps = {
  table: Table;
  size?: "sm" | "md" | "lg";
  page: number;
};

const PageButton = ({ table, size, page }: PageButtonProps) => {
  return (
    <Button
      size={size}
      variant="outline"
      aria-label="next-page"
      onClick={() => table.setPageIndex(page - 1)}
      isDisabled={table.getState().pagination.pageIndex === page - 1}
      mx="2px"
    >
      {page}
    </Button>
  );
};
