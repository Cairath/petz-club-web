import {
  Button,
  Card,
  CardBody,
  CardHeader,
  CardProps,
  Heading,
  Input,
  Stack,
  Textarea
} from "@chakra-ui/react";

export type Props = { poop?: boolean };

export const BioCard = ({ ...rest }: Props & CardProps) => {
  return (
    <Card variant="panel" {...rest}>
      <CardHeader>
        <Heading size="sm">Bio</Heading>
      </CardHeader>
      <CardBody>
        <Stack h="100%">
          <Input placeholder="Call name"></Input>
          <Textarea
            placeholder="Bio, additional info, other achievements etc."
            h="60%"
            resize="none"
          ></Textarea>
          <Button
            colorScheme="teal"
            variant="outline"
            alignSelf="end"
            mt="auto"
          >
            Save
          </Button>
        </Stack>
      </CardBody>
    </Card>
  );
};
