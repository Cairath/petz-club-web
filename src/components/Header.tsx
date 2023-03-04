import { Box, Heading, useColorModeValue } from "@chakra-ui/react";
import ProfilePic from "../assets/img/ProfileBackground.png";

export type Props = {
  title: string;
};

export const Header = ({ title }: Props) => {
  const textColor = useColorModeValue("white", "gray.900");

  return (
    <Box
      bgImage={ProfilePic}
      w="100%"
      h="150px"
      borderRadius="15px"
      bgPosition="50%"
      bgRepeat="no-repeat"
      pt="90px"
      textColor={textColor}
      mb="20px"
      mt="-85px"
      pl="40px"
      pb="70px"
    >
      <Heading>{title}</Heading>
    </Box>
  );
};
