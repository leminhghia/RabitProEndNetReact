import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './styles/index.css'
// import App from './App.jsx'
import { Bounce, ToastContainer } from 'react-toastify'
import { Provider } from 'react-redux'
import { store } from './redux/store.js'
import { router } from './router/router.jsx'
import { RouterProvider } from 'react-router-dom'
import { ThemeProvider } from '@emotion/react'
import theme from './styles/theme.js'
createRoot(document.getElementById('root')).render(
  <StrictMode>
    <Provider store={store}>
      <ThemeProvider theme={theme}>
        <ToastContainer
          position="top-right"
          autoClose={5000}
          hideProgressBar={false}
          newestOnTop={false}
          closeOnClick={false}
          rtl={false}
          pauseOnFocusLoss
          draggable
          pauseOnHover
          theme="light"
          transition={Bounce}
        />
        <RouterProvider router={router} />
      </ThemeProvider>
    </Provider>
  </StrictMode>
)
