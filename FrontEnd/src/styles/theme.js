import { createTheme } from '@mui/material/styles'

const theme = createTheme({
  palette: {
    primary: {
      main: '#1976d2', // Màu chính (ví dụ: xanh dương)
    },
    secondary: {
      main: '#dc004e', // Màu phụ (ví dụ: đỏ hồng)
    },
  },
  // Bạn có thể thêm các tùy chỉnh khác như typography, spacing, v.v.
})

export default theme
