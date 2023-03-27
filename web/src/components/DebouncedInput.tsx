import { Input, InputProps } from "@chakra-ui/react";
import { useEffect, useMemo, useState } from "react";

export type Props = {
  value: string | number;
  onChange: (value?: string | number) => void;
  debounceTime?: number;
};

export const DebouncedInput = ({
  value: controlledValue,
  onChange,
  debounceTime = 500,
  ...props
}: Props & Omit<InputProps, "onChange" | "value">) => {
  const onChangeWrapper = useMemo<{ onChange?: typeof onChange }>(
    () => ({}),
    []
  );

  useEffect(() => {
    // intentially mutate an object so we can depend on the stable wrapper object even if the callback changes
    onChangeWrapper.onChange = onChange;
  }, [onChangeWrapper, onChange]);

  const [value, setValue] = useState<string | number>(controlledValue ?? "");

  useEffect(() => {
    //prevent from setting undefined - changes the conmponent into uncontrolled
    setValue(controlledValue ?? "");
  }, [controlledValue]);

  useEffect(() => {
    const timeout = setTimeout(() => {
      onChangeWrapper.onChange?.(value);
    }, debounceTime);

    return () => clearTimeout(timeout);
  }, [value, debounceTime, onChangeWrapper]);

  return (
    <Input
      {...props}
      value={value}
      onChange={(e) => setValue(e.target.value)}
    />
  );
};
