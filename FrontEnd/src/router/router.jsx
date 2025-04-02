import { createBrowserRouter } from 'react-router-dom'
import App from '../App'
import HomePages from '../pages/Home/homePages'
import AboutBlog from '../pages/About/aboutBlog'
import Login from '../pages/user/login'
import Register from '../pages/user/register'
export const router = createBrowserRouter([
  {
    path: '/',
    element: <App />,
    children: [
      {
        path: '', // Tương đương path: '/'
        element: <HomePages />,
      },
      {
        path: 'about',
        element: <AboutBlog />,
      },
      {
        path: 'login',
        element: <Login />,
      },
      {
        path: 'register',
        element: <Register />,
      },
    ],
  },
])
