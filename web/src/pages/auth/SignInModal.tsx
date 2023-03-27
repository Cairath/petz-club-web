import {
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
  ModalOverlay,
  Stack,
  Switch,
  Text
} from "@chakra-ui/react";
import { useContext, useState } from "react";
import { useForm } from "react-hook-form";
import api from "../../api/api";
import { ClientUserInfo, UserSignIn } from "../../api/client";
import { UserContext } from "../../context/UserContext";

export type Props = {
  iconColor: string;
  isOpen: boolean;
  onClose: () => void;
  onRegistrationClicked: () => void;
};

export const SignInModal = ({
  iconColor,
  isOpen,
  onClose,
  onRegistrationClicked
}: Props) => {
  const [submitting, setSubmitting] = useState(false);
  const [signInError, setSignInError] = useState(false);

  const {
    handleSubmit,
    register,
    reset,
    formState: { errors }
  } = useForm<UserSignIn>();

  const { setUser } = useContext(UserContext);

  const onSubmit = (values: UserSignIn) => {
    setSubmitting(true);
    setSignInError(false);
    api
      .signIn(values)
      .then((clientUserInfo: ClientUserInfo) => {
        setUser({
          id: clientUserInfo.id,
          email: clientUserInfo.email,
          name: clientUserInfo.displayName,
          memberId: clientUserInfo.memberId
        });
      })
      .catch(() => setSignInError(true))
      .finally(() => setSubmitting(false));
  };

  const closeModal = () => {
    reset();
    setSignInError(false);
    onClose();
  };

  const registrationClicked = () => {
    closeModal();
    onRegistrationClicked();
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
              <Flex direction="column" alignItems="center">
                <FormControl width="70%" isInvalid={!!errors.email}>
                  <FormLabel fontSize="sm" fontWeight="normal">
                    Email
                  </FormLabel>
                  <Input
                    size="lg"
                    fontSize="sm"
                    borderRadius="15px"
                    {...register("email", { required: true })}
                    placeholder="Your email"
                  />
                </FormControl>

                <FormControl width="70%" isInvalid={!!errors.password} mt="1em">
                  <FormLabel fontSize="sm" fontWeight="normal">
                    Password
                  </FormLabel>
                  <Input
                    size="lg"
                    fontSize="sm"
                    borderRadius="15px"
                    type="password"
                    {...register("password", { required: "This is required" })}
                    placeholder="Your password"
                  />
                </FormControl>

                <FormControl
                  width="70%"
                  mt="1.2em"
                  display="flex"
                  alignItems="center"
                >
                  <FormLabel mb="0" fontSize="sm" fontWeight="normal">
                    Remember me
                  </FormLabel>
                  <Switch colorScheme="teal" {...register("rememberMe")} />
                </FormControl>

                <Stack direction="row" mt="2em">
                  <Text color="gray.500" fontWeight="medium">
                    Don't have an account?
                  </Text>
                  <Button
                    onClick={registrationClicked}
                    size="sm"
                    ms="0px"
                    ps="5px"
                    pe="10px"
                    color="teal"
                    variant="link"
                    aria-label="register"
                  >
                    <Text display={{ sm: "none", md: "flex" }}>Sign Up</Text>
                  </Button>
                </Stack>
                <Stack direction="row">
                  <Text color="gray.500" fontWeight="medium">
                    Forgot your password?
                  </Text>
                  <Button
                    color="teal"
                    fontWeight="bold"
                    variant="link"
                    size="sm"
                  >
                    Password Recovery
                  </Button>
                </Stack>
              </Flex>
            </ModalBody>

            <ModalFooter alignItems="baseline" pt="0px">
              {signInError && (
                <Text color="red" mr="1em">
                  The credentials you provided are incorrect.
                </Text>
              )}
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
                Log in
              </Button>
            </ModalFooter>
          </form>
        </ModalContent>
      </Modal>
    </>
  );
};
