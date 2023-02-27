import React, { useEffect, useState } from "react";
import { Notification } from "../api/client";

export interface User {
  id: number;
  name: string;
}

export const UserContext = React.createContext<{
  user: User;
  setUser: (user: User) => void;
  notifications: Notification[];
}>(null);
