import { configureStore } from '@reduxjs/toolkit'
import CounterReducer from './counter/counterSlide'
export const store = configureStore({
  reducer: {
    count: CounterReducer,
  },
})
