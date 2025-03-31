import { createBrowserRouter } from 'react-router-dom'
import App from '../App'
import HomePages from '../view/Home/homePages'
import AboutBlog from '../view/About/aboutBlog'

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
    ],
  },
])
