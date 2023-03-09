import {
  Alert,
  AlertDescription,
  AlertIcon,
  AlertProps
} from "@chakra-ui/react";

export const AffixAlreadyRegisteredAlert = (props: AlertProps) => {
  return (
    <Alert status="error" {...props}>
      <AlertIcon />
      <AlertDescription>This name is already registered.</AlertDescription>
    </Alert>
  );
};
