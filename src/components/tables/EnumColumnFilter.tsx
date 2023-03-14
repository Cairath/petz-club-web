import { Select } from "chakra-react-select";
import { useMemo } from "react";
import { EnumFilterOptions, FilterProps } from "./types";

export type Props = FilterProps & Omit<EnumFilterOptions, "type">;

export const EnumColumnFilter = ({
  column,
  enumValues,
  isSearchable
}: Props) => {
  const options = useMemo(
    () =>
      Object.keys(enumValues).map((enumKey) => ({
        value: enumKey,
        label: enumValues[enumKey]
      })),
    [enumValues]
  );

  const columnFilterValue = column.getFilterValue();
  const value = useMemo(
    () => options.find((v) => v.value === columnFilterValue),
    [options, columnFilterValue]
  );

  return (
    <>
      <Select
        size="sm"
        useBasicStyles
        isSearchable={isSearchable}
        isClearable
        chakraStyles={{
          container: (provided, _) => ({
            ...provided,
            mt: "5px",
            textTransform: "math-auto",
            fontWeight: "normal",
            fontFamily: "'Roboto', sans-serif"
          })
        }}
        options={options}
        placeholder=""
        value={value}
        onChange={(value) => column.setFilterValue(value)}
      ></Select>
    </>
  );
};
