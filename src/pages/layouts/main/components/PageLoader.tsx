import { CircularProgress, Flex } from "@chakra-ui/react";
export type Props = {
  loading: boolean;
};

export const PageLoader = ({ loading }: Props) => {
  return loading ? (
    <Flex w="100%" minH="500px" justifyContent="center" alignItems="center">
      <CircularProgress isIndeterminate color="teal.300" />
    </Flex>
  ) : null;
};
