import { useEffect, useRef, useState } from "react";
import api from "../api/api";
import { Notification } from "../api/client";
import { User, UserContext } from "./UserContext";

function getUserFromLS() {
  const userString = localStorage.getItem("user");
  if (userString !== undefined && userString !== null) {
    return JSON.parse(userString);
  } else return null;
}

export type Props = {
  children?: React.ReactNode;
};

//todo: rewrite this to something better than good-enough-for-testing
export const UserProvider = (props: Props) => {
  const [user, setUser] = useState(getUserFromLS);
  const [notifications, setNotifications] = useState<Notification[]>([]);

  useEffect(() => {
    const authenticateUser = async (id: number) => {
      await api.authenticate(id).then((isAuthenticated: boolean) => {
        if (isAuthenticated) {
          localStorage.setItem("user", JSON.stringify(user));
        } else {
          localStorage.removeItem("user");
          setUser(null);
        }
      });
    };

    if (user !== undefined && user !== null) {
      authenticateUser(user.id);
    } else {
      localStorage.removeItem("user");
    }
  }, [user]);

  useEffect(() => {
    const intervalCall = setInterval(async () => {
      if (user !== undefined && user !== null) {
        await api.getUserNotifications().then((notifications) => {
          setNotifications(notifications);
        });
      }
    }, 10000);
    return () => {
      clearInterval(intervalCall);
    };
  }, []);

  return (
    <UserContext.Provider value={{ user, setUser, notifications }}>
      {props.children}
    </UserContext.Provider>
  );
};
