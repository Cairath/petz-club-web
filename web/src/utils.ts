import { AffixStatus, AffixSyntax, GameVersion, PetStatus } from "./api/client";

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

export const gameVersionDisplay: Record<GameVersion, string> = {
  [GameVersion.Petz3]: "Petz 3",
  [GameVersion.Petz4]: "Petz 4",
  [GameVersion.Petz5]: "Petz 5"
};

export const petStatusDisplayData: Record<
  PetStatus,
  { name: string; color: string }
> = {
  [PetStatus.Active]: { name: "Active", color: "green" },
  [PetStatus.Inactive]: { name: "Retired", color: "gray" },
  [PetStatus.PendingRegistration]: {
    name: "Pending",
    color: "yellow"
  }
};
