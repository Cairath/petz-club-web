import {
  Box,
  Button,
  Card,
  CardBody,
  CardHeader,
  CardProps,
  Flex,
  FormControl,
  FormLabel,
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
import { useCallback, useMemo, useRef, useState } from "react";
import { useForm } from "react-hook-form";
import { BiTransfer } from "react-icons/bi";
import { FaGraduationCap } from "react-icons/fa";
import { FiArchive } from "react-icons/fi";
import { GiStorkDelivery } from "react-icons/gi";
import { MdRefresh } from "react-icons/md";
import { toast } from "react-toastify";
import api from "../../../api/api";
import {
  Age,
  PetProfileData,
  PetStatus,
  SetBioForm
} from "../../../api/client";
import { handleError } from "../../../api/requests";
import { FormError } from "../../../components/FormError";
import { AgePetAlertDialog } from "./AgePetAlertDialog";
import { yupResolver } from "@hookform/resolvers/yup";
import { setBioFormValidationSchema } from "../validation-schemas/SetBioFormValidationSchema";

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
          toast.success("Status changed successfully");
          onChanges();
        })
        .catch(handleError)
        .finally(() => setPetStatusSubmitting(false));
    },
    [petProfileData, onChanges]
  );

  const agePet = useCallback(() => {
    setPetAgingSubmitting(true);
    api
      .setAdult(petProfileData.id)
      .then(() => {
        toast.success("Age changed successfully");
        onChanges();
      })
      .catch(handleError)
      .finally(() => setPetAgingSubmitting(false));
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
        })
        .catch(handleError);
    },
    [petProfileData, onChanges]
  );

  const {
    handleSubmit,
    register,
    formState: { errors, isSubmitting },
    watch
  } = useForm<SetBioForm>({
    resolver: yupResolver(setBioFormValidationSchema),
    defaultValues: useMemo(() => {
      return {
        callName: petProfileData.callName,
        bio: petProfileData.bio,
        petId: petProfileData.id
      };
    }, [petProfileData])
  });

  const onSubmit = (values: SetBioForm) => {
    api
      .setBio(values)
      .then(() => {
        onChanges();
        toast.success("Bio has been set.");
      })
      .catch(handleError);
  };

  const watchBio = watch("bio");

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
                    onClick={onPetAgingDialogOpen}
                    leftIcon={<FaGraduationCap color={iconColor} />}
                    isLoading={isPetAgingSubmitting}
                  >
                    Age up
                  </Button>
                  <Text>
                    (will age up automatically{" "}
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
            <Box h="100%" w="50%" maxW="50%">
              <form
                onSubmit={handleSubmit(onSubmit)}
                style={{ height: "100%" }}
              >
                <Stack gap={1} h="100%">
                  <FormControl isInvalid={!!errors.callName}>
                    <FormLabel fontSize="sm" color="gray.500" fontWeight="bold">
                      Call Name
                    </FormLabel>
                    <Input
                      fontSize="sm"
                      maxLength={25}
                      {...register("callName")}
                    />
                    <FormError errors={errors} field="callName" />
                  </FormControl>

                  <FormControl height="60%">
                    <FormLabel fontSize="sm" color="gray.500" fontWeight="bold">
                      Bio
                    </FormLabel>
                    <Textarea
                      fontSize="sm"
                      placeholder="Bio, additional info, other achievements etc."
                      {...register("bio")}
                      resize="none"
                      maxLength={255}
                      h="85%"
                    ></Textarea>
                  </FormControl>

                  <Stack
                    direction="row"
                    width="100%"
                    justifyContent="space-between"
                  >
                    <Text>{watchBio?.length}/255</Text>
                    <Button
                      colorScheme="teal"
                      variant="link"
                      size="sm"
                      type="submit"
                      isLoading={isSubmitting}
                    >
                      Save
                    </Button>
                  </Stack>
                </Stack>
              </form>
            </Box>
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
        innerRef={cancelRef}
      />
    </>
  );
};
