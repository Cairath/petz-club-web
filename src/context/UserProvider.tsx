import { useEffect, useRef, useState } from "react";
import api from "../api/api";
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

  return (
    <UserContext.Provider value={{ user, setUser }}>
      {props.children}
    </UserContext.Provider>
  );
};
