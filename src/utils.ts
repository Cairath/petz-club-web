import { AffixStatus, AffixSyntax } from "./api/client";

export const syntaxDisplayName: Record<AffixSyntax, string> = {
  [AffixSyntax.Prefix]: "prefix",
  [AffixSyntax.Suffix]: "suffix",
  [AffixSyntax.Names]: "'s",
  [AffixSyntax.From]: "from",
  [AffixSyntax.Of]: "of",
  [AffixSyntax.The]: "the",
  [AffixSyntax.At]: "at"
};

export const affixStatusDisplayData: Record<
  AffixStatus,
  { name: string; color: string }
> = {
  [AffixStatus.Active]: { name: "Active", color: "green" },
  [AffixStatus.Inactive]: { name: "Inactive", color: "red" },
  [AffixStatus.PendingRegistration]: {
    name: "Pending",
    color: "yellow"
  }
};
