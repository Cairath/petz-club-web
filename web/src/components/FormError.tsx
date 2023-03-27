import { Box, FormErrorMessage } from "@chakra-ui/react";
import { FieldErrors, FieldValues } from "react-hook-form";

export type Props<T extends FieldValues> = {
  errors: FieldErrors<T>;
  field: keyof T;
};

export const FormError = <T extends FieldValues>({
  errors,
  field
}: Props<T>) => {
  return (
    <>
      <FormErrorMessage mt="0.5em">
        {errors[field]?.message?.toString()}
      </FormErrorMessage>
      {errors[field] === undefined && <Box minHeight="1.7em" />}
    </>
  );
};
