import {
  Alert,
  AlertIcon,
  Button,
  Checkbox,
  Flex,
  FormControl,
  FormLabel,
  Input,
  Link,
  Modal,
  ModalBody,
  ModalCloseButton,
  ModalContent,
  ModalFooter,
  ModalHeader,
  ModalOverlay,
  Stack,
  Text
} from "@chakra-ui/react";
import { yupResolver } from "@hookform/resolvers/yup";
import { api } from "api/api";
import { RegistrationForm } from "api/client";
import { handleError } from "api/requests";
import { FormError } from "components/FormError";
import { Space } from "components/Space";
import { useState } from "react";
import { useForm } from "react-hook-form";
import { registrationFormValidationSchema } from "./validation-schemas/RegistrationFormValidationSchema";

export type Props = {
  isOpen: boolean;
  onClose: () => void;
  onSignInClicked: () => void;
};

export const RegisterModal = ({ isOpen, onClose, onSignInClicked }: Props) => {
  const [submitting, setSubmitting] = useState(false);
  const [showSuccess, setShowSuccess] = useState(false);
  const [successEmail, setSuccessEmail] = useState<string>();

  const {
    handleSubmit,
    register,
    reset,
    formState: { errors }
  } = useForm<
    RegistrationForm & { confirmPassword: string; rulesAccepted: boolean }
  >({
    resolver: yupResolver(registrationFormValidationSchema)
  });

  const onSubmit = (values: RegistrationForm) => {
    setSubmitting(true);
    api
      .registerUser(values)
      .then(() => registrationSuccess(values.email!))
      .catch(handleError)
      .finally(() => setSubmitting(false));
  };

  const registrationSuccess = (email: string) => {
    reset();
    setShowSuccess(true);
    setSuccessEmail(email);
  };

  const closeModal = () => {
    reset();
    setShowSuccess(false);
    setSuccessEmail(undefined);
    onClose();
  };

  const signInClicked = () => {
    closeModal();
    onSignInClicked();
  };

  return (
    <>
      <Modal
        size="lg"
        isOpen={isOpen}
        onClose={closeModal}
        closeOnEsc={true}
        closeOnOverlayClick={false}
      >
        <ModalOverlay />
        <ModalContent p="20px">
          <form onSubmit={handleSubmit(onSubmit)}>
            <ModalHeader></ModalHeader>
            <ModalCloseButton m="27px" />
            <ModalBody pb={6}>
              {showSuccess && (
                <Alert status="success" mb="2em">
                  <AlertIcon />
                  Registration successful. A confirmation email has been sent to{" "}
                  {successEmail} - please check it to activate your account.
                </Alert>
              )}
              <Flex direction="column" alignItems="center" mt="1em">
                <Text
                  color="gray.500"
                  fontWeight="medium"
                  mb="2em"
                  textAlign="center"
                >
                  If you'd like to join our club, please register an account.
                  Your email will be used as your login, but will not be visible
                  to other members.
                </Text>

                <Text
                  color="gray.500"
                  fontWeight="medium"
                  mb="2em"
                  textAlign="center"
                >
                  Registering multiple accounts is bannable.
                </Text>
                <FormControl width="70%" isInvalid={!!errors.email}>
                  <FormLabel fontSize="sm" fontWeight="normal">
                    Email
                  </FormLabel>
                  <Input
                    size="lg"
                    fontSize="sm"
                    borderRadius="15px"
                    {...register("email")}
                    placeholder="Your email"
                  />
                  <FormError errors={errors} field="email" />
                </FormControl>

                <FormControl width="70%" isInvalid={!!errors.password}>
                  <FormLabel fontSize="sm" fontWeight="normal">
                    Password
                  </FormLabel>
                  <Input
                    size="lg"
                    fontSize="sm"
                    borderRadius="15px"
                    type="password"
                    {...register("password")}
                    placeholder="Your password"
                  />
                  <FormError errors={errors} field="password" />
                </FormControl>

                <FormControl width="70%" isInvalid={!!errors.confirmPassword}>
                  <FormLabel fontSize="sm" fontWeight="normal">
                    Confirm Password
                  </FormLabel>
                  <Input
                    size="lg"
                    fontSize="sm"
                    borderRadius="15px"
                    type="password"
                    {...register("confirmPassword")}
                    placeholder="Your password again"
                  />
                  <FormError errors={errors} field="confirmPassword" />
                </FormControl>

                <FormControl width="70%" isInvalid={!!errors.memberName}>
                  <FormLabel fontSize="sm" fontWeight="normal">
                    Display Name
                  </FormLabel>
                  <Input
                    size="lg"
                    fontSize="sm"
                    borderRadius="15px"
                    {...register("memberName")}
                    placeholder="Your display name"
                  />
                  <FormError errors={errors} field="memberName" />
                </FormControl>

                <FormControl
                  width="70%"
                  my="1.2em"
                  flexDirection="column"
                  display="flex"
                  alignItems="center"
                  isInvalid={!!errors.rulesAccepted}
                >
                  <Stack direction="row">
                    <Checkbox
                      colorScheme="teal"
                      {...register("rulesAccepted")}
                    ></Checkbox>
                    <Text fontSize="sm" ml="1em">
                      I read and agree to the
                      <Space />
                      <Link color="teal">Club Rules</Link> &{" "}
                      <Link color="teal">Privacy Policy</Link>
                    </Text>
                  </Stack>

                  <FormError errors={errors} field="rulesAccepted" />
                </FormControl>

                <Stack direction="row">
                  <Text color="gray.500" fontWeight="medium">
                    Already have an account?
                  </Text>
                  <Button
                    onClick={signInClicked}
                    size="sm"
                    ms="0px"
                    ps="5px"
                    pe="10px"
                    color="teal"
                    variant="link"
                    aria-label="register"
                  >
                    <Text display={{ sm: "none", md: "flex" }}>Sign In</Text>
                  </Button>
                </Stack>
              </Flex>
            </ModalBody>

            <ModalFooter alignItems="baseline">
              <Button
                type="submit"
                isLoading={submitting}
                bg="teal.300"
                color="white"
                _hover={{
                  bg: "teal.200"
                }}
                _active={{
                  bg: "teal.400"
                }}
              >
                Register
              </Button>
            </ModalFooter>
          </form>
        </ModalContent>
      </Modal>
    </>
  );
};
