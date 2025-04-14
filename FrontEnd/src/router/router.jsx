import { createBrowserRouter } from 'react-router-dom'
import App from '../App'
import HomePages from '../pages/Home/homePages'
import AboutBlog from '../pages/About/aboutBlog'
import Login from '../pages/user/login'
import Register from '../pages/user/register'
import QuenMatKhau from '../pages/user/QuenMatKhau'
import ProductMain from '../pages/product/ProductMaster'
import Admin from '../pages/adminPage/admin'
import DashBoard from '../Component/adminComponent/DashBoard'
import 'bootstrap/dist/css/bootstrap.min.css'
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
      {
        path: 'quenMatKhau',
        element: <QuenMatKhau />,
      },
      {
        path: 'product',
        element: <ProductMain />,
      },
    ],
  },
  {
    path: 'admin',
    exact: 'true',
    element: <Admin />,
    children: [
      {
        path: 'dashboard',

        element: <DashBoard />,
      },
    ],
  },
])
