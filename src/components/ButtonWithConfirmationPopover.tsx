import {
  Button,
  ButtonGroup,
  ButtonProps,
  FocusLock,
  IconButton,
  Popover,
  PopoverArrow,
  PopoverContent,
  PopoverTrigger,
  Stack,
  Text,
  Textarea,
  ThemeTypings,
  Tooltip,
  useDisclosure
} from "@chakra-ui/react";
import { ReactElement, useRef } from "react";

export type Props = {
  tooltip: string;
  withReason?: boolean;
  objectId: number;
  icon: ReactElement;
  prompt: string;
  confirmationButtonText: string;
  confirmationButtonColor: ThemeTypings["colorSchemes"];
  onConfirm: (objectId: number, reason: string) => void;
};

export const ButtonWithConfirmationPopover = ({
  tooltip,
  withReason = false,
  objectId,
  icon,
  prompt,
  confirmationButtonText,
  confirmationButtonColor,
  onConfirm,
  ...rest
}: Props & ButtonProps) => {
  const { onOpen, onClose, isOpen } = useDisclosure();
  const firstFieldRef = useRef(null);
  return (
    <Popover
      isOpen={isOpen}
      initialFocusRef={firstFieldRef}
      onOpen={onOpen}
      onClose={onClose}
      placement="left"
      closeOnBlur={true}
    >
      <PopoverTrigger>
        <div style={{ display: "inline-block" }}>
          <Tooltip label={tooltip}>
            <IconButton
              variant="outline"
              aria-label="cancel"
              icon={icon}
              {...rest}
            />
          </Tooltip>
        </div>
      </PopoverTrigger>
      <PopoverContent p={5}>
        <FocusLock persistentFocus={false}>
          <PopoverArrow />
          <Form
            withReason={withReason}
            prompt={prompt}
            confirmationButtonColor={confirmationButtonColor}
            confirmationButtonText={confirmationButtonText}
            firstFieldRef={firstFieldRef}
            onCancel={onClose}
            onConfirm={() => {
              onConfirm(objectId, "");
              onClose();
            }}
          />
        </FocusLock>
      </PopoverContent>
    </Popover>
  );
};

type FormProps = {
  withReason: boolean;
  prompt: string;
  confirmationButtonText: string;
  confirmationButtonColor: ThemeTypings["colorSchemes"];
  onCancel: () => void;
  onConfirm: () => void;
  firstFieldRef: React.MutableRefObject<null>;
};

const Form = ({
  firstFieldRef,
  prompt,
  confirmationButtonText,
  confirmationButtonColor,
  withReason,
  onCancel,
  onConfirm
}: FormProps) => {
  return (
    <Stack spacing={4}>
      <Text>{prompt}</Text>

      {withReason && (
        <>
          <Text>Please a provide reason:</Text>
          <Textarea placeholder="Reason" size="sm" />
        </>
      )}

      <ButtonGroup display="flex" justifyContent="flex-end">
        <Button variant="outline" onClick={onCancel} ref={firstFieldRef}>
          No
        </Button>
        <Button colorScheme={confirmationButtonColor} onClick={onConfirm}>
          {confirmationButtonText}
        </Button>
      </ButtonGroup>
    </Stack>
  );
};
