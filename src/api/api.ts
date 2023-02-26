import axios from "axios";
import { Client } from "./client";

export default new Client(
  process.env.NODE_ENV === "production" ? "tbd" : "https://localhost:7017",
  axios.create({ transformResponse: (data) => data, withCredentials: true })
);
