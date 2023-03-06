import React, { useCallback, useEffect, useState } from "react";
import api from "../api/api";
import { Notification } from "../api/client";
import { User, UserContext } from "./UserContext";

export type Props = {
  children?: React.ReactNode;
};

export const UserProvider = (props: Props) => {
  const [user, setUser] = useState<User | null>(undefined!);
  const [notifications, setNotifications] = useState<Notification[]>([]);

  const authenticateUser = useCallback(async () => {
    const clientUserInfo = await api.authenticate();

    if (clientUserInfo) {
      const newUser = {
        id: clientUserInfo.id,
        email: clientUserInfo.email,
        name: clientUserInfo.displayName
      };

      localStorage.setItem("user", JSON.stringify(newUser));
      setUser(newUser);
    } else {
      localStorage.removeItem("user");
      setUser(null!);
    }
  }, []);

  const refreshNotifications = useCallback(() => {
    if (user !== undefined && user !== null && document.hasFocus()) {
      api.getUserNotifications().then((notifications) => {
        setNotifications(notifications);
      });
    }
  }, [user]);

  useEffect(() => {
    authenticateUser();
  }, [authenticateUser]);

  useEffect(() => {
    refreshNotifications();

    const intervalCall = setInterval(() => {
      refreshNotifications();
    }, 1000 * 60 * 5);
    return () => {
      clearInterval(intervalCall);
    };
  }, [user, refreshNotifications]);

  return (
    <UserContext.Provider
      value={{ user, setUser, notifications, refreshNotifications }}
    >
      {props.children}
    </UserContext.Provider>
  );
};
