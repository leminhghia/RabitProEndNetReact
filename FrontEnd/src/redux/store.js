import { configureStore } from '@reduxjs/toolkit'
import themeReducer from './slices/themeSlice/drakMode'
import loginReducer from './slices/TaiKhoan/loginSlice'

export const store = configureStore({
  reducer: {
    theme: themeReducer,
    login: loginReducer,
  },
})
