import { DebouncedInput } from "../DebouncedInput";
import { FilterProps, TextFilterOptions } from "./types";

export type Props = FilterProps & Omit<TextFilterOptions, "type">;

export const TextColumnFilter = ({ column, table }: Props) => {
  const columnFilterValue = column.getFilterValue();
  return (
    <DebouncedInput
      size="sm"
      mt="5px"
      type="text"
      value={(columnFilterValue ?? "") as string}
      onChange={(value) => column.setFilterValue(value)}
    />
  );
};
