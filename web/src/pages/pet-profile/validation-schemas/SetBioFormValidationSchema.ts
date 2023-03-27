import * as yup from "yup";
import { ObjectSchema } from "yup";
import { SetBioForm } from "../../../api/client";

export const setBioFormValidationSchema: ObjectSchema<SetBioForm> = yup
  .object()
  .shape({
    petId: yup.number().defined(),
    callName: yup
      .string()
      .required("Display name is required")
      .min(2, "Display name must be at least 2 characters")
      .max(25, "Display name must be at most 25 characters")
      .matches(
        /^[A-Za-zÀ-ȕ' ]*$/,
        "Only letters, spaces and apostrophes allowed"
      )
      .matches(
        /^[A-Za-zÀ-ȕ]([ ]*?[A-Za-zÀ-ȕ'])*[A-Za-zÀ-ȕ']*$/,
        "Space shouldn't be the first or the last character"
      ),
    bio: yup.string().defined().max(255, "Bio can be at most 255 characters")
  });
