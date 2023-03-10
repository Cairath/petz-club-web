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
    }

    return Promise.reject({ ...error });
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
