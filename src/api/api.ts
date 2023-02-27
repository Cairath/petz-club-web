import axios, { AxiosResponse } from "axios";
import { Client } from "./client";
import { handleDates } from "./interceptors/parseDatesInterceptor";

const instance = axios.create({
  withCredentials: true
});

instance.interceptors.response.use((originalResponse: AxiosResponse) => {
  handleDates(originalResponse.data);
  return originalResponse;
});

export default new Client(
  process.env.NODE_ENV === "production" ? "tbd" : "https://localhost:7017",
  instance
);
