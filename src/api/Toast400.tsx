import { Flex, ListItem, Text, UnorderedList } from "@chakra-ui/react";

export type ErrorData = {
  title?: string;
  errors: Record<string, string[]>;
};

export type Props = {
  errorData: ErrorData;
};

export const Toast400 = ({ errorData }: Props) => {
  return (
    <Flex direction="column">
      <Text fontWeight="bold">{errorData.title}</Text>
      <UnorderedList>
        {Object.keys(errorData.errors).map((field) => {
          const fieldErrors = errorData.errors[field];

          return fieldErrors.map((error: string) => (
            <ListItem>{error}</ListItem>
          ));
        })}
      </UnorderedList>
    </Flex>
  );
};
