import {
  Alert,
  AlertDescription,
  AlertIcon,
  AlertProps
} from "@chakra-ui/react";

export const SimilarAffixNameExistsAlert = (props: AlertProps) => {
  return (
    <Alert status="warning" {...props}>
      <AlertIcon />
      <AlertDescription>
        A very similar name is already registered. The algorithm isn't perfect
        and the final decision belongs to the Registrar, but make sure your new
        affix name is not too similar to already existing ones.
      </AlertDescription>
    </Alert>
  );
};
