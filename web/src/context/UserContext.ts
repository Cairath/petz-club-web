import React from "react";
import { Notification } from "../api/client";

export interface User {
  id: number;
  email: string;
  name: string;
  memberId: number;
}

export const UserContext = React.createContext<{
  user: User | null;
  setUser: (user: User | null) => void;
  notifications: Notification[];
  refreshNotifications: () => void;
}>(null!);
