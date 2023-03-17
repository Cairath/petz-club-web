import {
  AlertDialog,
  AlertDialogBody,
  AlertDialogContent,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogOverlay,
  Button,
  Text
} from "@chakra-ui/react";

export type Props = {
  isOpen: boolean;
  onConfirm: () => void;
  onClose: () => void;
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  ref: React.RefObject<any>;
};
export const AgePetAlertDialog = ({
  isOpen,
  onConfirm,
  onClose,
  ref
}: Props) => {
  return (
    <AlertDialog isOpen={isOpen} leastDestructiveRef={ref} onClose={onClose}>
      <AlertDialogOverlay>
        <AlertDialogContent>
          <AlertDialogHeader fontSize="lg" fontWeight="bold">
            Age Up Pet
          </AlertDialogHeader>

          <AlertDialogBody>
            <Text fontWeight="bold" mb="1em">
              This cannot be reversed.
            </Text>
            <Text mb="1em">
              The pet will move from junior to adult class in Conformation, will
              be able to enter other show types and be eligible for breeding.
            </Text>
            <Text>
              If it is currently entered as a junior in any show it will still
              be judged as a junior.
            </Text>
          </AlertDialogBody>

          <AlertDialogFooter>
            <Button ref={ref} onClick={onClose}>
              Cancel
            </Button>
            <Button colorScheme="red" onClick={onConfirm} ml={3}>
              Age up
            </Button>
          </AlertDialogFooter>
        </AlertDialogContent>
      </AlertDialogOverlay>
    </AlertDialog>
  );
};
