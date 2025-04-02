import { configureStore } from '@reduxjs/toolkit'
import themeReducer from './slices/themeSlice/drakMode'

export const store = configureStore({
  reducer: {
    theme: themeReducer,
  },
})
