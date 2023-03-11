import { Card, CardBody, CardProps, Image } from "@chakra-ui/react";
import { PetProfileData } from "../../../api/client";

export type Props = {
  profileData: PetProfileData;
};

export const PetPhotoCard = ({ profileData, ...rest }: Props & CardProps) => {
  return (
    <Card variant="panel" minWidth="200px" {...rest}>
      <CardBody display="flex" placeContent="center">
        <Image src="http://i.imgur.com/rFNHVyy.png" />
      </CardBody>
    </Card>
  );
};
