import { createTheme } from '@mui/material/styles'

const getTheme = (darkMode) =>
  createTheme({
    palette: {
      mode: darkMode ? 'dark' : 'light',
      primary: {
        main: '#1976d2', // Xanh dương
      },
      secondary: {
        main: '#dc004e', // Đỏ hồng
      },
    },
  })
export default getTheme
