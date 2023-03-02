import { SmallCloseIcon } from "@chakra-ui/icons";
import {
  Button,
  ButtonGroup,
  FocusLock,
  IconButton,
  Popover,
  PopoverArrow,
  PopoverContent,
  PopoverTrigger,
  Stack,
  Text,
  Tooltip,
  useDisclosure
} from "@chakra-ui/react";
import { useRef } from "react";

export type CancelRegistrationProps = {
  pendingAffixId: number;
  onConfirm: (pendingAffixId: number) => void;
};

export const CancelRegistrationButton = ({
  pendingAffixId,
  onConfirm
}: CancelRegistrationProps) => {
  const { onOpen, onClose, isOpen } = useDisclosure();
  const firstFieldRef = useRef(null);
  return (
    <Popover
      isOpen={isOpen}
      initialFocusRef={firstFieldRef}
      onOpen={onOpen}
      onClose={onClose}
      placement="left"
      closeOnBlur={false}
    >
      <PopoverTrigger>
        <div>
          <Tooltip label="Cancel registration">
            <IconButton
              variant="outline"
              aria-label="cancel"
              icon={<SmallCloseIcon />}
            />
          </Tooltip>
        </div>
      </PopoverTrigger>
      <PopoverContent p={5}>
        <FocusLock persistentFocus={false}>
          <PopoverArrow />
          <Form
            firstFieldRef={firstFieldRef}
            onCancel={onClose}
            onConfirm={() => onConfirm(pendingAffixId)}
          />
        </FocusLock>
      </PopoverContent>
    </Popover>
  );
};

type FormProps = {
  onCancel: () => void;
  onConfirm: () => void;
  firstFieldRef: React.MutableRefObject<null>;
};

const Form = ({ firstFieldRef, onCancel, onConfirm }: FormProps) => {
  return (
    <Stack spacing={4}>
      <Text>Are you sure you want to cancel this registration?</Text>
      <ButtonGroup display="flex" justifyContent="flex-end">
        <Button variant="outline" onClick={onCancel} ref={firstFieldRef}>
          No
        </Button>
        <Button colorScheme="red" onClick={onConfirm}>
          Yes
        </Button>
      </ButtonGroup>
    </Stack>
  );
};
