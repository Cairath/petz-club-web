import { Column, RowData, Table as ReactTable } from "@tanstack/react-table";

export enum ColumnFilterType {
  Text = "text",
  Enum = "enum"
}

export type Table = ReactTable<any>;

/* eslint-disable @typescript-eslint/no-explicit-any */
export type FilterProps = {
  column: Column<any, unknown>;
  table: Table;
};
/* eslint-enable @typescript-eslint/no-explicit-any */

export interface FilterOptionsBase<T extends ColumnFilterType> {
  type: T;
}

// eslint-disable-next-line @typescript-eslint/no-empty-interface
export interface TextFilterOptions
  extends FilterOptionsBase<ColumnFilterType.Text> {}

export interface EnumFilterOptions
  extends FilterOptionsBase<ColumnFilterType.Enum> {
  enumValues: Record<string, string>;
  omitEnumValues?: string[];
  isSearchable?: boolean;
}

export type FilterOptions = TextFilterOptions | EnumFilterOptions;

declare module "@tanstack/table-core" {
  // eslint-disable-next-line @typescript-eslint/no-unused-vars
  interface ColumnMeta<TData extends RowData, TValue> {
    filter?: FilterOptions;
    isNumeric?: boolean;
    width?: string;
    minWidth?: string;
  }
}
