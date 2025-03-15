import { createBrowserRouter } from "react-router-dom";

import HomePage from "../features/home/HomePage";
import App from "../app/layout/App";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [{ path: "", element: <HomePage /> }],
  },
]);
