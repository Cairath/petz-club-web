import { useContext } from "react";
import api from "../../api/api";
import { UserContext } from "../../context/UserContext";

export const SignOut = () => {
  const { setUser } = useContext(UserContext);

  api.signOut().then(() => setUser(null));
  return <div>sign out</div>;
};
