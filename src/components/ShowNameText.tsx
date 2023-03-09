import { Text } from "@chakra-ui/react";
import { useMemo } from "react";
import { AffixSyntax } from "../api/client";
import { Space } from "./Space";

export type Props = {
  affixName: string;
  affixSyntax: AffixSyntax;
};

export const ShowNameText = ({ affixName, affixSyntax }: Props) => {
  const text = useMemo(() => {
    let name = affixName;
    if (
      affixSyntax === AffixSyntax.From ||
      affixSyntax === AffixSyntax.Of ||
      affixSyntax === AffixSyntax.At
    ) {
      if (affixName.startsWith("The ")) {
        name = `t${affixName.substring(1)}`;
      }
    }

    const petName = "Fluffy Butt";

    switch (affixSyntax) {
      case AffixSyntax.From:
        return (
          <Text>
            {petName}
            <Space />
            <Text as="span" fontWeight="bold">
              from {name}
            </Text>
          </Text>
        );
      case AffixSyntax.Of:
        return (
          <Text>
            {petName}
            <Space />
            <Text as="span" fontWeight="bold">
              of {name}
            </Text>
          </Text>
        );
      case AffixSyntax.The:
        return (
          <Text>
            {petName}
            <Space />
            <Text as="span" fontWeight="bold">
              the {name}
            </Text>
          </Text>
        );
      case AffixSyntax.Prefix:
        return (
          <Text>
            <Text as="span" fontWeight="bold">
              {name}
            </Text>
            <Space />
            {petName}
          </Text>
        );
      case AffixSyntax.Suffix:
        return (
          <Text>
            {petName}
            <Space />
            <Text as="span" fontWeight="bold">
              {name}
            </Text>
          </Text>
        );
      case AffixSyntax.Names:
        return (
          <Text>
            <Text as="span" fontWeight="bold">
              {name}'s
            </Text>
            <Space />
            {petName}
          </Text>
        );
      case AffixSyntax.At:
        return (
          <Text>
            {petName}
            <Space />
            <Text as="span" fontWeight="bold">
              at {name}
            </Text>
          </Text>
        );
    }
  }, [affixSyntax, affixName]);

  return text;
};
