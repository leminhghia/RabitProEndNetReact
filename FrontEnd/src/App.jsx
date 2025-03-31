import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import { useSelector, useDispatch } from 'react-redux'
import { increment, decrement } from './redux/counter/counterSlide'
import { Outlet } from 'react-router-dom'
import './App.css'

function App() {
  const count = useSelector((state) => state.counter?.value ?? 0)
  console.log('Current count:', count)
  const dispatch = useDispatch()
  return (
    <>
      <div>
        <h1>Chào mừng đến với RABITPROENDNETREACT</h1>
        <nav>
          <a href="/">Trang chủ</a>
          <a href="/about">Về chúng tôi</a>
        </nav>
        <Outlet />
      </div>
      <div>
        <a href="https://vite.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      <div>
        <div>
          <button
            aria-label="Increment value"
            onClick={() => dispatch(increment())}
          >
            Increment
          </button>
          <span>{count}</span>
          <button
            aria-label="Decrement value"
            onClick={() => dispatch(decrement())}
          >
            Decrement
          </button>
        </div>
      </div>
    </>
  )
}

export default App
