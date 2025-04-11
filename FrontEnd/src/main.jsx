import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './styles/index.css'
import { Bounce, ToastContainer } from 'react-toastify'
import { Provider, useSelector } from 'react-redux'
import { store } from './redux/store.js'
import { router } from './router/router.jsx'
import { RouterProvider } from 'react-router-dom'
import getTheme from './styles/theme.js'
import { ThemeProvider, CssBaseline } from '@mui/material'

// Tạo component ThemeWrapper để bọc ThemeProvider
const ThemeWrapper = ({ children }) => {
  const darkMode = useSelector((state) => state.theme.darkMode)
  const theme = getTheme(darkMode)

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      {children}
    </ThemeProvider>
  )
}

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <Provider store={store}>
      {/* Đưa ThemeWrapper vào trong Provider */}
      <ThemeWrapper>
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
      </ThemeWrapper>
    </Provider>
  </StrictMode>
)
