import { ListItem, Text, UnorderedList } from "@chakra-ui/react";

export const AffixRegistrationRules = () => {
  return (
    <>
      <Text fontSize="sm" color="gray.500" fontWeight="bold" pl="7px" pb="5px">
        AFFIX RULES
      </Text>
      <UnorderedList mb="2em">
        <ListItem>Between 3 and 35 characters long</ListItem>
        <ListItem>No special characters (!@#$% etc.) and numbers</ListItem>
        <ListItem>Full CAPS not allowed</ListItem>
        <ListItem>Proper word capitalization is required</ListItem>
        <ListItem>Must make sense grammatically</ListItem>
        <ListItem>Offensive or vulgar terms will be rejected</ListItem>
      </UnorderedList>
    </>
  );
};
