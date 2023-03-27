import { PropsWithChildren, useContext } from "react";
import { Navigate } from "react-router-dom";
import { UserContext } from "../context/UserContext";

export const ProtectedRoute = ({ children }: PropsWithChildren) => {
  const { user } = useContext(UserContext);

  if (!user) {
    return <Navigate to="/landing" replace />;
  }

  return <>{children}</>;
};
