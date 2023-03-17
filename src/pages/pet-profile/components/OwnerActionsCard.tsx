import {
  Button,
  Card,
  CardBody,
  CardHeader,
  CardProps,
  Flex,
  Heading,
  Input,
  Stack,
  Textarea
} from "@chakra-ui/react";

export type Props = { poop?: boolean };

export const OwnerActionsCard = ({ ...rest }: Props & CardProps) => {
  return (
    <Card variant="panel" {...rest}>
      <CardHeader>
        <Heading size="sm">Owner's Panel</Heading>
      </CardHeader>
      <CardBody>
        <Flex direction="row" h="100%">
          <Stack
            direction="column"
            spacing="3"
            flex="1 1 auto"
            alignItems="center"
          >
            <Button
              variant="outline"
              px="2em"
              colorScheme="teal"
              width="50%"
              minWidth="250px"
              size="sm"
            >
              Age
            </Button>
            <Button
              variant="outline"
              px="2em"
              colorScheme="teal"
              width="50%"
              minWidth="250px"
              size="sm"
            >
              Retire
            </Button>
            <Button
              variant="outline"
              px="2em"
              colorScheme="teal"
              width="50%"
              minWidth="250px"
              size="sm"
            >
              Transfer ownership
            </Button>
            <Button
              variant="outline"
              px="2em"
              colorScheme="teal"
              width="50%"
              minWidth="250px"
              size="sm"
            >
              Mark as available for breeding
            </Button>
          </Stack>
          <Stack h="100%" flex="1 1 auto">
            <Input placeholder="Call name"></Input>
            <Textarea
              placeholder="Bio, additional info, other achievements etc."
              h="80%"
              resize="none"
            ></Textarea>
            <Button
              colorScheme="teal"
              variant="link"
              alignSelf="end"
              mt="auto"
              size="sm"
            >
              Save
            </Button>
          </Stack>
        </Flex>
      </CardBody>
    </Card>
  );
};
