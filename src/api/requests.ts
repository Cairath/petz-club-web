import { Sex, Species } from "./client";

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
  affixId?: number | undefined;
  affixName?: string | undefined;
  breedId?: number | undefined;
  sex?: Sex;
  species?: Species;
  showName?: string | undefined;
}
