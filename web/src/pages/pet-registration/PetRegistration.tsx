import {
  Button,
  Card,
  CardBody,
  Flex,
  FormControl,
  FormLabel,
  Stack,
  Text,
  useColorModeValue
} from "@chakra-ui/react";
import { api } from "api/api";
import { Select } from "chakra-react-select";
import { IconBox } from "components/IconBox";
import orderBy from "lodash-es/orderBy";
import { useContext, useEffect, useMemo, useState } from "react";
import { useForm } from "react-hook-form";
import { BsHeartHalf } from "react-icons/bs";
import { FaCat, FaDog, FaPaw, FaTrophy } from "react-icons/fa";
import {
  PetRegistrationForm,
  RegistrationType,
  Species
} from "../../api/client";
import { handleError } from "../../api/requests";
import { Header } from "../../components/Header";
import { UserContext } from "../../context/UserContext";

export const PetRegistration = () => {
  const { user } = useContext(UserContext);

  const [breedsLoading, setBreedsLoading] = useState<boolean>(false);
  const [breeds, setBreeds] = useState<{ label: string; value: number }[]>();

  const {
    handleSubmit,
    register,
    setValue,
    reset,
    watch,
    control,
    formState: { errors }
  } = useForm<PetRegistrationForm>({
    //resolver: yupResolver({})
  });

  const speciesWatch = watch("species");
  const regTypeWatch = watch("registrationType");

  useEffect(() => {
    if (speciesWatch === undefined) {
      return;
    }
    setBreedsLoading(true);

    api
      .getBreedNamesList(speciesWatch)
      .then((breedList) => {
        let options = breedList.map((breed) => ({
          value: breed.id,
          label: breed.name
        }));

        options = orderBy(options, (breed) => breed.label, "asc");
        setBreeds(options);
      })
      .catch(handleError)
      .finally(() => setBreedsLoading(false));
  }, [speciesWatch]);

  const typeDescription = useMemo(() => {
    switch (regTypeWatch) {
      case RegistrationType.PurebredShow:
        return "Purebred show quality petz fully conform to their breed standard.";
      case RegistrationType.PurebredPet:
        return "Purebred pet quality petz can have coat colors and patterns not fully adhering to the breed standards. They cannot enter conformation shows.";
      case RegistrationType.Mixed:
        return "Mixed pets must still have proper body proportions and look like their species. They cannot enter comformation shows.";
    }
  }, [regTypeWatch]);

  return (
    <>
      <Header title="Pet Registration" />
      <Card variant="panel" mb="20px">
        <CardBody>
          <form>
            <Stack direction="column" gap={2}>
              <Stack direction="row" gap={2} justifyContent="center">
                <FancyButton
                  text="Cat"
                  isActive={speciesWatch === Species.Catz}
                  icon={<FaCat />}
                  onClick={() => setValue("species", Species.Catz)}
                />
                <FancyButton
                  text="Dog"
                  isActive={speciesWatch === Species.Dogz}
                  icon={<FaDog />}
                  onClick={() => setValue("species", Species.Dogz)}
                />
              </Stack>
              <Stack direction="row" gap={2} justifyContent="center">
                <FancyButton
                  text="Purebred - Show"
                  isActive={regTypeWatch === RegistrationType.PurebredShow}
                  isDisabled={speciesWatch === undefined}
                  icon={<FaTrophy />}
                  onClick={() =>
                    setValue("registrationType", RegistrationType.PurebredShow)
                  }
                />
                <FancyButton
                  text="Purebred - Pet"
                  isActive={regTypeWatch === RegistrationType.PurebredPet}
                  isDisabled={speciesWatch === undefined}
                  icon={<FaPaw />}
                  onClick={() =>
                    setValue("registrationType", RegistrationType.PurebredPet)
                  }
                />
                <FancyButton
                  text="Mixed"
                  isActive={regTypeWatch === RegistrationType.Mixed}
                  isDisabled={speciesWatch === undefined}
                  icon={<BsHeartHalf />}
                  onClick={() =>
                    setValue("registrationType", RegistrationType.Mixed)
                  }
                />
              </Stack>
              <Text
                alignSelf="center"
                fontWeight="medium"
                color="gray.500"
                minH="21px"
              >
                {typeDescription}
              </Text>
            </Stack>

            <FormControl>
              <FormLabel>Breed</FormLabel>
              <Flex flexDirection="row">
                <Select
                  placeholder="Breed"
                  useBasicStyles={true}
                  options={breeds}
                  chakraStyles={{
                    container: (provided, _) => ({
                      ...provided,
                      minWidth: "300px"
                    })
                  }}
                  isLoading={breedsLoading}
                ></Select>
                <Select placeholder="Variety" useBasicStyles={true}></Select>
              </Flex>
            </FormControl>
          </form>
        </CardBody>
      </Card>
      <Card variant="tablePanel">
        <CardBody></CardBody>
      </Card>
    </>
  );
};

type FancyButtonProps = {
  isActive: boolean;
  isDisabled?: boolean;
  text: string;
  icon: React.ReactNode;
  onClick: () => void;
};
const FancyButton = ({
  isActive,
  isDisabled,
  text,
  icon,
  onClick
}: FancyButtonProps) => {
  const activeBg = useColorModeValue("white", "gray.700");
  const inactiveBg = useColorModeValue("white", "gray.700");
  const activeColor = useColorModeValue("gray.700", "white");
  const inactiveColor = useColorModeValue("gray.400", "gray.400");

  return (
    <Button
      isDisabled={isDisabled}
      boxSize="initial"
      justifyContent="flex-start"
      alignItems="center"
      bg={isActive ? activeBg : "transparent"}
      ps={{
        sm: "10px",
        xl: "16px"
      }}
      py="12px"
      borderRadius="15px"
      w="auto"
      _active={{
        bg: "inherit",
        transform: "none",
        borderColor: "transparent"
      }}
      _focus={{
        boxShadow: "none"
      }}
      onClick={onClick}
    >
      <Flex>
        <IconBox
          bg={isActive ? "teal.300" : inactiveBg}
          color={isActive ? "white" : "teal.300"}
          h="30px"
          w="30px"
          me="12px"
        >
          {icon}
        </IconBox>
        <Text
          color={isActive ? activeColor : inactiveColor}
          my="auto"
          fontSize="sm"
          pt="3px"
        >
          {text}
        </Text>
      </Flex>
    </Button>
  );
};
