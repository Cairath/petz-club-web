import {
  Box,
  Button,
  Flex,
  FormControl,
  FormErrorMessage,
  FormLabel,
  Modal,
  ModalBody,
  ModalCloseButton,
  ModalContent,
  ModalFooter,
  ModalHeader,
  ModalOverlay,
  Select,
  Text,
  useDisclosure
} from "@chakra-ui/react";
import maxBy from "lodash-es/maxBy";
import { useCallback, useEffect, useMemo, useState } from "react";
import { Controller, useForm } from "react-hook-form";
import { toast } from "react-toastify";
import api from "../../api/api";
import {
  AffixRegistrationForm,
  AffixSyntax,
  SimilarName
} from "../../api/client";
import { DebouncedInput } from "../../components/DebouncedInput";
import { ShowNameText } from "../../components/ShowNameText";
import { Space } from "../../components/Space";
import { syntaxDisplayName } from "../../utils";
import { AffixAlreadyRegisteredAlert } from "./components/AffixAlreadyRegisteredAlert";
import { AffixRegistrationRules } from "./components/AffixRegistrationRules";
import { SimilarAffixNameExistsAlert } from "./components/SimilarAffixNameExistsAlert";

export type Props = {
  isDisabled: boolean;
  onSubmitted: () => void;
};

export const RegisterAffixModal = ({ isDisabled, onSubmitted }: Props) => {
  const { isOpen, onOpen, onClose } = useDisclosure();
  const [similarNames, setSimilarNames] = useState<SimilarName[]>([]);
  const [highestSimilarity, setHighestSimilarity] = useState<
    number | undefined
  >(0);
  const {
    handleSubmit,
    register,
    formState: { errors, isSubmitting },
    watch,
    control,
    reset
  } = useForm<AffixRegistrationForm>();

  const onSubmit = (values: AffixRegistrationForm) => {
    api.registerAffix(values).then(() => {
      onSubmitted();
      reset();
      onClose();
      toast.success("Affix registration has been submitted");
    });
  };

  const watchName = watch("name");
  const watchSyntax = watch("syntax");

  const getSimilarNames = useCallback((affix: string) => {
    api
      .getSimilarNames(affix)
      .then((similarNames: SimilarName[]) => setSimilarNames(similarNames));
  }, []);

  useEffect(() => {
    if (similarNames.length === 0) {
      setHighestSimilarity(0);
    }

    setHighestSimilarity(
      maxBy(similarNames, "similarityPercentage")?.similarityPercentage
    );
  }, [similarNames]);

  const similarNamesDisplay = useMemo(() => {
    if (similarNames.length === 0) {
      return <Text>not found</Text>;
    }

    return (
      <Flex direction="column">
        {similarNames.map((similarName: SimilarName) => {
          return (
            <Text key={similarName.id}>
              <Text as="span" fontWeight="bold">
                {similarName.name}
              </Text>
              <Space /> ({syntaxDisplayName[similarName.syntax]})
              <Space />-<Space />
              {similarName.similarityPercentage}%
            </Text>
          );
        })}
      </Flex>
    );
  }, [similarNames]);

  return (
    <>
      <Button
        px="2em"
        bg="teal.300"
        color="white"
        _hover={{
          bg: "teal.200"
        }}
        _active={{
          bg: "teal.400"
        }}
        onClick={onOpen}
        isDisabled={isDisabled}
      >
        Register a new affix
      </Button>

      <Modal
        size="lg"
        isOpen={isOpen}
        onClose={onClose}
        closeOnEsc={true}
        closeOnOverlayClick={false}
      >
        <ModalOverlay />
        <ModalContent p="20px">
          <form onSubmit={handleSubmit(onSubmit)}>
            <ModalHeader>Affix Registration</ModalHeader>
            <ModalCloseButton m="27px" />
            <ModalBody pb={6}>
              <AffixRegistrationRules />
              <Flex>
                <FormControl
                  flex="2 1 auto"
                  width="auto"
                  mr="1em"
                  isInvalid={!!errors.name}
                >
                  <FormLabel
                    pl="0.5em"
                    fontSize="sm"
                    color="gray.500"
                    fontWeight="bold"
                  >
                    AFFIX
                  </FormLabel>
                  <Controller
                    control={control}
                    name="name"
                    rules={{
                      required: "This is required",
                      minLength: {
                        value: 3,
                        message: "Minimum 3 characters"
                      },
                      maxLength: {
                        value: 35,
                        message: "Maximum 35 characters"
                      },
                      pattern: {
                        value: /^[A-Za-zÀ-ȕ]([ ]?[A-Za-zÀ-ȕ])*[A-Za-zÀ-ȕ]*$/,
                        message:
                          "No special characters allowed. The name cannot start nor end wtih a space."
                      }
                    }}
                    render={({ field: { onChange, value, name } }) => (
                      <DebouncedInput
                        name={name}
                        debounceTime={500}
                        value={value}
                        onChange={(e) => {
                          onChange(e);
                          if (typeof e === "string" && e.length > 0) {
                            getSimilarNames(e);
                          } else {
                            setSimilarNames([]);
                          }
                        }}
                      />
                    )}
                  />
                  <FormErrorMessage mt="0.5em">
                    {errors.name?.message?.toString()}
                  </FormErrorMessage>
                  {errors.name === undefined && <Box minHeight="1.7em" />}
                </FormControl>

                <FormControl flex="1 1 auto" width="auto">
                  <FormLabel
                    pl="0.5em"
                    fontSize="sm"
                    color="gray.500"
                    fontWeight="bold"
                  >
                    SYNTAX
                  </FormLabel>
                  <Select
                    {...register("syntax", { required: "This is required" })}
                  >
                    {Object.keys(AffixSyntax).map((key) => {
                      return (
                        <option key={key} value={key}>
                          {syntaxDisplayName[key as AffixSyntax]}
                        </option>
                      );
                    })}
                  </Select>
                </FormControl>
              </Flex>

              <Flex
                direction="column"
                mt="2em"
                justifyContent="center"
                textAlign="center"
              >
                <Text fontSize="sm" color="gray.500" fontWeight="bold">
                  FULL SHOW NAME CONSTRUCTION
                </Text>
                {watchName && watchSyntax ? (
                  <ShowNameText
                    affixName={watchName}
                    affixSyntax={watchSyntax}
                  />
                ) : (
                  <Text>please select values</Text>
                )}
              </Flex>
              <Flex
                mt="2em"
                direction="column"
                justifyContent="center"
                textAlign="center"
              >
                <Text fontSize="sm" color="gray.500" fontWeight="bold">
                  SIMILAR NAMES
                </Text>
                {similarNamesDisplay}
                {highestSimilarity &&
                  highestSimilarity >= 60 &&
                  highestSimilarity !== 100 && (
                    <SimilarAffixNameExistsAlert mt="1em" />
                  )}
                {highestSimilarity && highestSimilarity === 100 && (
                  <AffixAlreadyRegisteredAlert mt="2em" />
                )}
              </Flex>
            </ModalBody>

            <ModalFooter>
              <Button onClick={onClose} mr={3}>
                Cancel
              </Button>
              <Button
                type="submit"
                isLoading={isSubmitting}
                bg="teal.300"
                color="white"
                _hover={{
                  bg: "teal.200"
                }}
                _active={{
                  bg: "teal.400"
                }}
                // isDisabled={highestSimilarity === 100}
              >
                Submit
              </Button>
            </ModalFooter>
          </form>
        </ModalContent>
      </Modal>
    </>
  );
};
