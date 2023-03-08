import { Input, InputProps } from "@chakra-ui/react";
import { useEffect, useState } from "react";

export type Props = {
  value: string | number;
  onChange: (value: string | number) => void;
  debounce?: number;
};

export const DebouncedInput = ({
  value: initialValue,
  onChange,
  debounce = 50,
  ...rest
}: Props & Omit<InputProps, "onChange">) => {
  const [value, setValue] = useState(initialValue);

  useEffect(() => {
    setValue(initialValue);
  }, [initialValue]);

  useEffect(() => {
    const timeout = setTimeout(() => {
      onChange(value);
    }, debounce);

    return () => clearTimeout(timeout);
  }, [value, debounce, onChange]);

  return (
    <Input {...rest} value={value} onChange={(e) => setValue(e.target.value)} />
  );
};
