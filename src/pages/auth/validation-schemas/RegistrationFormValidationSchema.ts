import * as yup from "yup";
import { ObjectSchema } from "yup";
import { RegistrationForm } from "../../../api/client";

export const registrationFormValidationSchema: ObjectSchema<
  RegistrationForm & { confirmPassword: string }
> = yup.object().shape({
  email: yup.string().required("Email is required").email("Email is invalid"),
  password: yup
    .string()
    .required("Password is required")
    .min(8, "Password must be at least 8 characters")
    .max(100, "Password must be at most 100 characters"),
  confirmPassword: yup
    .string()
    .oneOf([yup.ref("password"), undefined], "Passwords don't match")
    .required("Confirm your password"),
  memberName: yup
    .string()
    .required("Display name is required")
    .min(3, "Display name must be at least 3 characters")
    .max(30, "Display name must be at most 30 characters")
    .matches(/^[A-Za-zÀ-ȕ' ]*$/, "Only letters, spaces and apostrophes allowed")
    .matches(
      /^[A-Za-zÀ-ȕ]([ ]*?[A-Za-zÀ-ȕ'])*[A-Za-zÀ-ȕ']*$/,
      "Space shouldn't be the first or the last character"
    )
    .matches(
      /^[A-Za-zÀ-ȕ]([ ]?[A-Za-zÀ-ȕ'])*[A-Za-zÀ-ȕ']*$/,
      "Name shouldn't contain consecutive spaces"
    )
});
