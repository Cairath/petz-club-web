import { QuestionOutlineIcon } from "@chakra-ui/icons";
import {
  Box,
  Button,
  Card,
  CardBody,
  CardHeader,
  CardProps,
  Heading,
  Image,
  Link,
  Stack,
  Text,
  Tooltip
} from "@chakra-ui/react";
import { DateTime } from "luxon";
import Slider from "react-slick";

import "./slick.css";

export type Props = { poop?: boolean };

export const MonthlyShowPoseCard = ({ ...rest }: Props & CardProps) => {
  const settings = {
    dots: true,
    infinite: true,
    autoplay: false,
    slidesToShow: 1
  };

  return (
    <Card variant="panel" {...rest}>
      <CardHeader>
        <Heading size="sm" display="flex" alignItems="center">
          Show Pictures for {DateTime.now().toFormat("LLLL")}
          <Tooltip
            label="Show pictures are automatically reset on the first day of each month.
          The picture must be not edited and have white background.
          Please keep in mind you may not reuse previously uploaded pictures."
          >
            <QuestionOutlineIcon ml="10px" h="16px" />
          </Tooltip>
        </Heading>
      </CardHeader>
      <CardBody>
        <Slider {...settings}>
          <Box>
            <Stack
              direction="column"
              justifyContent="center"
              alignItems="center"
            >
              <Stack direction="row">
                <Text fontWeight="bold">Conformation -</Text>
                <Button colorScheme="teal" variant="link" size="sm" ml="2px!">
                  Upload
                </Button>
              </Stack>

              <Image
                src="http://i.imgur.com/rFNHVyy.png"
                objectFit="none"
                minH="200px"
              />
            </Stack>
          </Box>
          <Box>
            <Stack
              direction="column"
              justifyContent="center"
              alignItems="center"
            >
              <Stack direction="row">
                <Text fontWeight="bold">Agility -</Text>
                <Button colorScheme="teal" variant="link" size="sm" ml="2px!">
                  Upload
                </Button>
              </Stack>
              <Image
                src="http://i.imgur.com/rFNHVyy.png"
                objectFit="none"
                minH="200px"
              />
            </Stack>
          </Box>
          <Box>
            <Stack
              direction="column"
              justifyContent="center"
              alignItems="center"
            >
              <Stack direction="row">
                <Text fontWeight="bold">Obedience -</Text>
                <Button colorScheme="teal" variant="link" size="sm" ml="2px!">
                  Upload
                </Button>
              </Stack>
              <Image
                src="http://i.imgur.com/rFNHVyy.png"
                objectFit="none"
                minH="200px"
              />
            </Stack>
          </Box>
        </Slider>
      </CardBody>
    </Card>
  );
};
