import axios, { AxiosError } from "axios";
import { toast } from "react-toastify";
import { Client } from "./client";
import { handleDates } from "./interceptors/parseDatesInterceptor";
import { ErrorData, Toast400 } from "./Toast400";

const instance = axios.create({
  withCredentials: true
});

const isErrorData = (error: AxiosError): error is AxiosError<ErrorData> => {
  return (
    typeof error?.response?.data === "object" &&
    error.response.data !== null &&
    "title" in error.response.data
  );
};

const errorHandler = (error: AxiosError) => {
  if (!error.response) {
    toast.error(
      "There was a problem communicating with the server. Check your internet connection or try again later.",
      {
        position: "top-center"
      }
    );
  }

  if (error.response?.status === 500) {
    toast.error("An unexpected error has occured.", {
      position: "top-right"
    });
    return Promise.reject({ ...error });
  }

  if (error?.response?.status === 400) {
    if (isErrorData(error)) {
      toast.error(<Toast400 errorData={error.response.data} />, {
        position: "top-right"
      });
    } else {
      toast.error("An unexpected error has occured.", {
        position: "top-right"
      });
    }

    return Promise.reject({ ...error });
  }

  if (error?.response?.status === 401) {
    if (!(error.request.responseURL as string).endsWith("sign-in")) {
      toast.error("Credentials expired or invalid. Please refresh the page.", {
        position: "top-right"
      });
    }

    return Promise.reject(error.response);
  }

  if (error?.response?.status === 403) {
    toast.error("You are not authorized to perform this action.", {
      position: "top-right"
    });

    return Promise.reject(error.response);
  }
};

instance.interceptors.response.use(
  (originalResponse) => {
    handleDates(originalResponse.data);
    return originalResponse;
  },
  (originalError) => errorHandler(originalError)
);

const client = new Client(
  process.env.NODE_ENV === "production" ? "tbd" : "https://localhost:7017",
  instance
);

export default client;
