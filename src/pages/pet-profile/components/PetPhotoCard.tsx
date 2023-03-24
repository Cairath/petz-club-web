import {
  Box,
  Button,
  Card,
  CardBody,
  CardFooter,
  CardProps,
  Flex,
  Image,
  useDisclosure
} from "@chakra-ui/react";
import { api } from "api/api";
import { PetProfileData } from "api/client";
import { handleError } from "api/requests";
import { PictureUploadModal } from "components/PictureUploadModal";
import { useCallback, useEffect, useMemo, useState } from "react";
import { toast } from "react-toastify";

export type Props = {
  profileData: PetProfileData;
  header?: string;
  isOwner: boolean;
  onChanges: () => void;
};

export const PetPhotoCard = ({
  profileData,
  header,
  isOwner,
  onChanges,
  ...rest
}: Props & CardProps) => {
  const { isOpen, onOpen, onClose } = useDisclosure();
  const [isShowingRegistrationPic, setShowingRegistrationPic] = useState(false);

  const profilePicUrl = useMemo(() => {
    if (
      profileData.profilePicture === undefined ||
      profileData.profilePicture === null
    ) {
      return undefined;
    }

    const profilePicture = profileData.profilePicture;

    const two = profilePicture.substring(0, 2);
    const four = profilePicture.substring(0, 4);

    return `/userpics/profile/${two}/${four}/${profilePicture}`;
  }, [profileData]);

  const registrationPicUrl = useMemo(() => {
    if (
      profileData.registrationPicture === undefined ||
      profileData.registrationPicture === null
    ) {
      return " /images/catsilhouette.png";
    }

    const registrationPicture = profileData.registrationPicture;

    const two = registrationPicture.substring(0, 2);
    const four = registrationPicture.substring(0, 4);

    return `/userpics/registration/${two}/${four}/${registrationPicture}`;
  }, [profileData]);

  const removeProfilePic = useCallback(() => {
    api
      .deleteProfilePic(profileData.id)
      .then(() => {
        setShowingRegistrationPic(true);
        toast.success("Profile picture has been removed");
        onChanges();
      })
      .catch(handleError);
  }, [profileData, onChanges]);

  const showRemoveButton = useMemo(
    () =>
      profileData.profilePicture !== undefined &&
      profileData.profilePicture !== null,
    [profileData]
  );

  useEffect(() => {
    if (profileData.profilePicture == null) {
      setShowingRegistrationPic(true);
    }
  }, [profileData]);

  const profilePicUploaded = useCallback(() => {
    onChanges();
    setShowingRegistrationPic(false);
  }, [onChanges]);

  return (
    <>
      <PictureUploadModal
        petId={profileData.id}
        onUploadSuccess={profilePicUploaded}
        isOpen={isOpen}
        onClose={onClose}
      />
      <Card variant="panel" minWidth="200px" minHeight="320px" {...rest}>
        <CardBody
          display="flex"
          placeContent="center"
          flexDirection="column"
          alignItems="center"
          pb="0px"
        >
          <Image
            src={isShowingRegistrationPic ? registrationPicUrl : profilePicUrl}
            objectFit="none"
          />
        </CardBody>
        <CardFooter px="0px" pt="0px">
          {isOwner && (
            <Flex direction="row" width="100%" pt="1em">
              {profilePicUrl && (
                <>
                  {!isShowingRegistrationPic ? (
                    <Button
                      variant="link"
                      colorScheme="teal"
                      size="sm"
                      onClick={() => setShowingRegistrationPic(true)}
                    >
                      Show registration pic
                    </Button>
                  ) : (
                    <Button
                      variant="link"
                      colorScheme="teal"
                      size="sm"
                      onClick={() => setShowingRegistrationPic(false)}
                    >
                      Show profile pic
                    </Button>
                  )}
                </>
              )}
              <Box ml="auto">
                {showRemoveButton && (
                  <Button
                    variant="link"
                    colorScheme="teal"
                    size="sm"
                    mr="10px"
                    onClick={removeProfilePic}
                  >
                    Remove profile pic
                  </Button>
                )}
                <Button
                  variant="link"
                  colorScheme="teal"
                  size="sm"
                  onClick={onOpen}
                >
                  Upload new profile pic
                </Button>
              </Box>
            </Flex>
          )}
        </CardFooter>
      </Card>
    </>
  );
};
