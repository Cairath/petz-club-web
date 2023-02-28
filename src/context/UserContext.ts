import React from "react";
import { Notification } from "../api/client";

export interface User {
  id: number;
  name: string;
}

export const UserContext = React.createContext<{
  user: User;
  setUser: (user: User | null) => void;
  notifications: Notification[];
  refreshNotifications: () => void;
}>(null!);
