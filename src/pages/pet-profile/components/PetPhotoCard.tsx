import {
  Button,
  Card,
  CardBody,
  CardProps,
  Flex,
  Image,
  useDisclosure
} from "@chakra-ui/react";
import { PictureUploadModal } from "components/PictureUploadModal";
import { PetProfileData } from "api/client";

export type Props = {
  profileData: PetProfileData;
  header?: string;
  isOwner: boolean;
};

export const PetPhotoCard = ({
  profileData,
  header,
  isOwner,
  ...rest
}: Props & CardProps) => {
  const { isOpen, onOpen, onClose } = useDisclosure();

  return (
    <>
      <PictureUploadModal
        isOpen={isOpen}
        onClose={onClose}
        petId={profileData.id}
      />
      <Card variant="panel" minWidth="200px" {...rest}>
        <CardBody
          display="flex"
          placeContent="center"
          flexDirection="column"
          alignItems="center"
        >
          <Image src="http://i.imgur.com/rFNHVyy.png" objectFit="none" />
          {isOwner && (
            <Flex direction="row" width="100%">
              <Button variant="link" colorScheme="teal" size="sm">
                Show registration pic
              </Button>
              <Button
                variant="link"
                colorScheme="teal"
                size="sm"
                ml="auto"
                onClick={onOpen}
              >
                Upload new
              </Button>
              <Button variant="link" colorScheme="teal" size="sm" ml="10px">
                Remove
              </Button>
            </Flex>
          )}
        </CardBody>
      </Card>
    </>
  );
};
