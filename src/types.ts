import { Column, RowData, Table } from "@tanstack/react-table";
import React from "react";

export type WithChildren = {
  children: string | JSX.Element | JSX.Element[] | (() => JSX.Element);
};

export type FilterProps = {
  column: Column<any, unknown>;
  table: Table<any>;
};

declare module "@tanstack/table-core" {
  interface ColumnMeta<TData extends RowData, TValue> {
    Filter?: React.FC<FilterProps>;
    isNumeric?: boolean;
    width?: string;
    minWidth?: string;
  }
}
