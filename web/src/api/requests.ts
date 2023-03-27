import api from "../api/api";
import { Age, GameVersion, PetStatus, Sex, Species } from "./client";

export const handleError = () => {
  /* already handled in axios, don't span console */
};

export interface Pagination {
  pageSize: number;
  page: number;
}

export enum SortDirection {
  Asc = "Asc",
  Desc = "Desc"
}

export interface Sorting {
  sortField?: string | undefined;
  sortDirection?: SortDirection;
}

// due to AsParameters being quite new, NSwag support is very limited - does not generate a model and ignores enums. to be revisited later.
export interface PetListFilters {
  ownerId?: number | undefined;
  ownerName?: string | undefined;
  affixId?: number | undefined;
  affixName?: string | undefined;
  pedigreeNumber?: string | undefined;
  breedId?: number | undefined;
  breedName?: string | undefined;
  sex?: Sex;
  age?: Age;
  species?: Species;
  showName?: string | undefined;
  status?: PetStatus;
  gameVersion?: GameVersion;
}

export const getPetsList = (
  filters: PetListFilters,
  pagination: Pagination,
  sorting: Sorting
) => {
  return api.getPets(
    filters?.ownerId,
    filters?.ownerName,
    filters?.showName,
    filters?.affixId,
    filters?.affixName,
    filters?.pedigreeNumber,
    filters?.breedId,
    filters?.breedName,
    filters?.sex,
    filters?.age,
    filters?.species,
    filters?.status,
    filters?.gameVersion,
    pagination.pageSize,
    pagination.page,
    sorting.sortField,
    sorting.sortDirection
  );
};
