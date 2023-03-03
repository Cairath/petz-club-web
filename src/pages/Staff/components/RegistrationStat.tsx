import { ArrowForwardIcon } from "@chakra-ui/icons";
import {
  Card,
  CardBody,
  Flex,
  Icon,
  Link,
  Stat,
  StatHelpText,
  StatLabel,
  StatNumber,
  Text
} from "@chakra-ui/react";
import { IconType } from "react-icons/lib";
import { Link as ReactRouterLink } from "react-router-dom";
import IconBox from "../../../components/Icons/IconBox";

export type Props = {
  label: string;
  value: number;
  url: string;
  icon: IconType;
};

export const RegistrationStat = ({ label, value, url, icon }: Props) => {
  return (
    <Card minH="83px" variant="defaultNoShadow">
      <CardBody>
        <Flex flexDirection="row" align="center" justify="center" w="100%">
          <Stat me="auto">
            <StatLabel fontSize="sm" color="gray.400" fontWeight="bold">
              {label}
            </StatLabel>
            <StatNumber fontSize="lg" py="0.5rem">
              {value}
            </StatNumber>
            <StatHelpText m="0px" color="gray.400">
              <Link
                as={ReactRouterLink}
                to={url}
                p="0px"
                variant="no-hover"
                bg="transparent"
                my={{ sm: "1.5rem", lg: "0px" }}
              >
                <Flex>
                  <Text
                    fontWeight="bold"
                    cursor="pointer"
                    transition="all .5s ease"
                    my={{ sm: "1.5rem", lg: "0px" }}
                    _hover={{ me: "4px" }}
                  >
                    Go to registrations page
                  </Text>
                  <ArrowForwardIcon
                    w="20px"
                    h="20px"
                    fontSize="2xl"
                    transition="all .5s ease"
                    mx=".3rem"
                    cursor="pointer"
                    pb="1px"
                    _hover={{ transform: "translateX(20%)" }}
                  />
                </Flex>
              </Link>
            </StatHelpText>
          </Stat>
          <IconBox
            as="box"
            h={"45px"}
            w={"45px"}
            bg={value === 0 ? "green.500" : "red.500"}
          >
            <Icon as={icon} color="white" w="20px" h="20px" />
          </IconBox>
        </Flex>
      </CardBody>
    </Card>
  );
};
