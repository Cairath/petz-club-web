import { Text } from "@chakra-ui/react";
import { useMemo } from "react";
import { AffixSyntax, RegisteredAffixListItem } from "../../../api/client";
import { Space } from "../../../components/own/Space";

export type Props = {
  affix: RegisteredAffixListItem;
};

export const ShowNameText = ({ affix }: Props) => {
  const text = useMemo(() => {
    let name = affix.name;
    if (affix.syntax === AffixSyntax.From || affix.syntax === AffixSyntax.Of) {
      if (affix.name.startsWith("The ")) {
        name = `t${affix.name.substring(1)}`;
      }
    }

    const petName = "Fluffy Butt";

    switch (affix.syntax) {
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
    }
  }, [affix]);

  return text;
};
