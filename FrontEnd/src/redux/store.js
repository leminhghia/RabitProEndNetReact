import { configureStore } from '@reduxjs/toolkit'
import CounterReducer from './slices/counter/counterSlide'
export const store = configureStore({
  reducer: {
    count: CounterReducer,
  },
})
