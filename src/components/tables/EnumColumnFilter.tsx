import { Select } from "chakra-react-select";
import { useMemo } from "react";
import { EnumFilterOptions, FilterProps } from "./types";
import { pull } from "lodash-es";

export type Props = FilterProps & Omit<EnumFilterOptions, "type">;

export const EnumColumnFilter = ({
  column,
  enumValues,
  omitEnumValues,
  isSearchable
}: Props) => {
  const options = useMemo(() => {
    const enumKeys = Object.keys(enumValues);

    if (omitEnumValues !== undefined && omitEnumValues.length > 0) {
      pull(enumKeys, ...omitEnumValues);
    }

    return enumKeys.map((enumKey) => ({
      value: enumKey,
      label: enumValues[enumKey]
    }));
  }, [enumValues, omitEnumValues]);

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
        onChange={(value) => column.setFilterValue(value?.value)}
      ></Select>
    </>
  );
};
