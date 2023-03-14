import { flexRender } from "@tanstack/react-table";
import { useMemo } from "react";
import { EnumColumnFilter } from "./EnumColumnFilter";
import { TextColumnFilter } from "./TextColumnFilter";
import { ColumnFilterType, FilterOptions, FilterProps } from "./types";

export type Props = {
  filterOptions?: FilterOptions;
  filterProps: FilterProps;
};

export const ColumnFilter = ({
  filterOptions,
  filterProps
}: Props): JSX.Element | null => {
  const filterComp = useMemo(() => {
    switch (filterOptions?.type) {
      case ColumnFilterType.Enum:
        return flexRender(EnumColumnFilter, {
          ...filterProps,
          ...filterOptions
        });
      case ColumnFilterType.Text:
        return flexRender(TextColumnFilter, filterProps);
      default:
        return flexRender(null, filterProps);
    }
  }, [filterOptions, filterProps]);

  return filterComp as JSX.Element | null;
};
