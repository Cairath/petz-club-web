import {
  Box,
  Button,
  Flex,
  FormControl,
  FormErrorMessage,
  FormLabel,
  Heading,
  Input,
  Link,
  Switch,
  Text,
  useColorModeValue
} from "@chakra-ui/react";
import { useContext } from "react";
import { useForm } from "react-hook-form";
import { Link as ReactRouterLink } from "react-router-dom";
import api from "../../api/api";
import { ClientUserInfo, UserSignIn } from "../../api/client";
import signInImage from "../../assets/img/signInImage.png";
import { UserContext } from "../../context/UserContext";

export const SignIn = () => {
  const titleColor = useColorModeValue("teal.300", "teal.200");
  const textColor = useColorModeValue("gray.400", "white");

  const { user, setUser } = useContext(UserContext);

  const {
    handleSubmit,
    register,
    formState: { errors, isSubmitting }
  } = useForm();

  const onSubmit = (values: UserSignIn) => {
    api.signIn(values).then((clientUserInfo: ClientUserInfo) =>
      setUser({
        id: clientUserInfo.id,
        email: clientUserInfo.email,
        name: clientUserInfo.displayName
      })
    );
  };

  return (
    <Box w="100%">
      <Box w="100%">
        <Flex
          h={{ sm: "initial", md: "75vh", lg: "85vh" }}
          w="100%"
          maxW="1044px"
          mx="auto"
          justifyContent="space-between"
          mb="30px"
          pt={{ sm: "100px", md: "0px" }}
        >
          <Flex
            alignItems="center"
            justifyContent="start"
            style={{ userSelect: "none" }}
            w={{ base: "100%", md: "50%", lg: "42%" }}
          >
            <Flex
              direction="column"
              w="100%"
              background="transparent"
              p="48px"
              mt={{ md: "150px", lg: "80px" }}
            >
              <Heading color={titleColor} fontSize="32px" mb="10px">
                Welcome Back {user?.name} {user?.id}
              </Heading>
              <Text
                mb="36px"
                ms="4px"
                color={textColor}
                fontWeight="bold"
                fontSize="14px"
              >
                Enter your email and password to sign in
              </Text>
              <form onSubmit={handleSubmit(onSubmit)}>
                <FormControl isInvalid={!!errors.email}>
                  <Flex
                    direction="row"
                    w="100%"
                    background="transparent"
                    alignItems="center"
                  >
                    <FormLabel
                      htmlFor="email"
                      fontSize="sm"
                      ms="4px"
                      mb="4px"
                      fontWeight="normal"
                    >
                      Email
                    </FormLabel>
                    <FormErrorMessage mt="0px">
                      {errors.email?.message?.toString()}
                    </FormErrorMessage>
                  </Flex>
                  <Input
                    id="email"
                    placeholder="Your email adress"
                    borderRadius="15px"
                    mb="24px"
                    fontSize="sm"
                    type="text"
                    size="lg"
                    {...register("email", { required: "This is required" })}
                  />
                </FormControl>
                <FormControl isInvalid={!!errors.email}>
                  <Flex
                    direction="row"
                    w="100%"
                    background="transparent"
                    alignItems="center"
                  >
                    <FormLabel
                      htmlFor="password"
                      ms="4px"
                      fontSize="sm"
                      fontWeight="normal"
                    >
                      Password
                    </FormLabel>
                    <FormErrorMessage mt="0px">
                      {errors?.password?.message?.toString()}
                    </FormErrorMessage>
                  </Flex>
                  <Input
                    id="password"
                    borderRadius="15px"
                    mb="36px"
                    fontSize="sm"
                    type="password"
                    placeholder="Your password"
                    size="lg"
                    {...register("password", {
                      required: "This is required"
                    })}
                  />
                </FormControl>
                <FormControl display="flex" alignItems="center">
                  <Switch
                    id="remember-login"
                    colorScheme="teal"
                    me="10px"
                    {...register("rememberMe")}
                  />
                  <FormLabel
                    htmlFor="remember-login"
                    mb="0"
                    ms="1"
                    fontWeight="normal"
                  >
                    Remember me
                  </FormLabel>
                </FormControl>
                <Button
                  fontSize="10px"
                  isLoading={isSubmitting}
                  type="submit"
                  bg="teal.300"
                  w="100%"
                  h="45"
                  mb="20px"
                  color="white"
                  mt="20px"
                  _hover={{
                    bg: "teal.200"
                  }}
                  _active={{
                    bg: "teal.400"
                  }}
                >
                  SIGN IN
                </Button>
              </form>
              <Flex
                flexDirection="column"
                justifyContent="center"
                alignItems="center"
                maxW="100%"
                mt="0px"
              >
                <Text color={textColor} fontWeight="medium">
                  Don't have an account?
                  <Link
                    as={ReactRouterLink}
                    to="/sign-up"
                    color={titleColor}
                    ms="5px"
                    fontWeight="bold"
                  >
                    Sign Up
                  </Link>
                  <Link
                    as={ReactRouterLink}
                    to="/dashboard"
                    color={titleColor}
                    ms="5px"
                    fontWeight="bold"
                  >
                    Dash
                  </Link>
                </Text>
              </Flex>
            </Flex>
          </Flex>
          <Box
            display={{ base: "none", md: "block" }}
            overflowX="hidden"
            h="100%"
            w="40vw"
            position="absolute"
            right="0px"
          >
            <Box
              bgImage={signInImage}
              w="100%"
              h="100%"
              bgSize="cover"
              bgPosition="50%"
              position="absolute"
              borderBottomLeftRadius="20px"
            />
          </Box>
        </Flex>
      </Box>
    </Box>
  );
};
