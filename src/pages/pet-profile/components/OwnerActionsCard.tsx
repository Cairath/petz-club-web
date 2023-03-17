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
  Switch,
  Text,
  Textarea,
  useColorModeValue,
  useDisclosure
} from "@chakra-ui/react";
import { DateTime } from "luxon";
import { useCallback, useRef, useState } from "react";
import { BiTransfer } from "react-icons/bi";
import { FaGraduationCap } from "react-icons/fa";
import { FiArchive } from "react-icons/fi";
import { GiStorkDelivery } from "react-icons/gi";
import { MdRefresh } from "react-icons/md";
import { toast } from "react-toastify";
import api from "../../../api/api";
import { Age, PetProfileData, PetStatus } from "../../../api/client";
import { AgePetAlertDialog } from "./AgePetAlertDialog";

export type Props = {
  petProfileData: PetProfileData;
  onChanges: () => void;
};

export const OwnerActionsCard = ({
  petProfileData,
  onChanges,
  ...rest
}: Props & CardProps) => {
  const iconColor = useColorModeValue("black", "white");

  const {
    isOpen: isPetAgingDialogOpen,
    onOpen: onPetAgingDialogOpen,
    onClose: onPetAgingDialogClose
  } = useDisclosure();
  const cancelRef = useRef();

  const [isPetStatusSubmitting, setPetStatusSubmitting] = useState(false);
  const [isPetAgingSubmitting, setPetAgingSubmitting] = useState(false);

  const setPetStatus = useCallback(
    (isActive: boolean) => {
      setPetStatusSubmitting(true);
      api
        .setPetActiveStatus({ petId: petProfileData.id, active: isActive })
        .then(() => {
          setPetStatusSubmitting(false);
          toast.success("Status changed successfully");
          onChanges();
        });
    },
    [petProfileData, onChanges]
  );

  const agePet = useCallback(() => {
    setPetAgingSubmitting(true);
    api.setAdult(petProfileData.id).then(() => {
      setPetAgingSubmitting(false);
      toast.success("Age changed successfully");
      onChanges();
    });
  }, [petProfileData, onChanges]);

  const setBreedingAvailibility = useCallback(
    (isAvailable: boolean) => {
      api
        .setBreedingAvailability({
          petId: petProfileData.id,
          isAvailable: isAvailable
        })
        .then(() => {
          toast.success("Breeding status changed successfully");
          onChanges();
        });
    },
    [petProfileData, onChanges]
  );

  return (
    <>
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
              pt="0.5em"
              textAlign="center"
            >
              {petProfileData.age === Age.Junior && (
                <>
                  <Button
                    variant="ghost"
                    size="sm"
                    textAlign="start"
                    colorScheme="teal"
                    // onClick={agePet}
                    onClick={onPetAgingDialogOpen}
                    leftIcon={<FaGraduationCap color={iconColor} />}
                    isLoading={isPetAgingSubmitting}
                  >
                    Age up
                  </Button>
                  <Text>
                    (will age up automatically in{" "}
                    {DateTime.fromJSDate(petProfileData.registrationDate)
                      .plus({ months: 6 })
                      .toRelative()}
                    )
                  </Text>
                </>
              )}
              {petProfileData.status === PetStatus.Active && (
                <Button
                  variant="ghost"
                  size="sm"
                  textAlign="start"
                  colorScheme="teal"
                  onClick={() => setPetStatus(false)}
                  leftIcon={<FiArchive color={iconColor} />}
                  isLoading={isPetStatusSubmitting}
                >
                  Retire
                </Button>
              )}
              {petProfileData.status === PetStatus.Inactive && (
                <Button
                  variant="ghost"
                  size="sm"
                  textAlign="start"
                  colorScheme="teal"
                  onClick={() => setPetStatus(true)}
                  leftIcon={<MdRefresh color={iconColor} />}
                  isLoading={isPetStatusSubmitting}
                >
                  Restore from retirement
                </Button>
              )}
              <Button
                variant="ghost"
                size="sm"
                textAlign="start"
                colorScheme="teal"
                leftIcon={<BiTransfer color={iconColor} />}
              >
                Transfer ownership
              </Button>

              {petProfileData.age === Age.Adult && (
                <Stack direction="row" alignItems="center" pt="0.5em">
                  <GiStorkDelivery color={iconColor} />
                  <Text fontWeight="bold">Available for breeding:</Text>
                  <Switch
                    colorScheme="teal"
                    isChecked={petProfileData.isAvailableForBreeding}
                    onChange={(e) => setBreedingAvailibility(e.target.checked)}
                  />
                </Stack>
              )}
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
      <AgePetAlertDialog
        isOpen={isPetAgingDialogOpen}
        onConfirm={() => {
          agePet();
          onPetAgingDialogClose();
        }}
        onClose={onPetAgingDialogClose}
        ref={cancelRef}
      />
    </>
  );
};
