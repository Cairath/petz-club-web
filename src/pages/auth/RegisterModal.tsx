import {
  Alert,
  AlertIcon,
  Button,
  Flex,
  FormControl,
  FormLabel,
  Input,
  Modal,
  ModalBody,
  ModalCloseButton,
  ModalContent,
  ModalFooter,
  ModalHeader,
  ModalOverlay
} from "@chakra-ui/react";
import { yupResolver } from "@hookform/resolvers/yup";
import { useState } from "react";
import { useForm } from "react-hook-form";
import api from "../../api/api";
import { RegistrationForm } from "../../api/client";
import { handleError } from "../../api/requests";
import { FormError } from "../../components/FormError";
import { registrationFormValidationSchema } from "./validation-schemas/RegistrationFormValidationSchema";

export type Props = {
  isOpen: boolean;
  onClose: () => void;
};

export const RegisterModal = ({ isOpen, onClose }: Props) => {
  const [submitting, setSubmitting] = useState(false);
  const [showSuccess, setShowSuccess] = useState(false);
  const [successEmail, setSuccessEmail] = useState<string>();

  const {
    handleSubmit,
    register,
    reset,
    formState: { errors }
  } = useForm<RegistrationForm & { confirmPassword: string }>({
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
