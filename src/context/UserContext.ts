import React, { useEffect, useState } from "react";

export interface User {
  id: number;
  name: string;
}

export const UserContext = React.createContext<{
  user: User;
  setUser: (user: User) => void;
}>(null);
