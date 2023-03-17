import {
  Button,
  Card,
  CardBody,
  CardHeader,
  CardProps,
  Flex,
  Heading,
  Image
} from "@chakra-ui/react";
import { PetProfileData } from "../../../api/client";

export type Props = {
  profileData: PetProfileData;
  header?: string;
};

export const PetPhotoCard = ({
  profileData,
  header,
  ...rest
}: Props & CardProps) => {
  return (
    <Card variant="panel" minWidth="200px" {...rest}>
      <CardBody
        display="flex"
        placeContent="center"
        flexDirection="column"
        alignItems="center"
      >
        {/* <div
          style={{
            background: "url(http://i.imgur.com/rFNHVyy.png) no-repeat 50% 0",
            height: "250px",
            width: "400px"
          }}
        ></div> */}
        <Image src="http://i.imgur.com/rFNHVyy.png" objectFit="none" />
        <Flex direction="row" width="100%">
          <Button variant="link" colorScheme="teal" size="sm">
            Show registration pic
          </Button>
          <Button variant="link" colorScheme="teal" size="sm" ml="auto">
            Upload new
          </Button>
          <Button variant="link" colorScheme="teal" size="sm" ml="10px">
            Remove
          </Button>
        </Flex>
      </CardBody>
    </Card>
  );
};
