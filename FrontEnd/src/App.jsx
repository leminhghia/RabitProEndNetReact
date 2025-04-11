import { Outlet } from 'react-router-dom'

import Box from '@mui/material/Box'
// import Header from './Component/header'
import HeaderText from './Component/headerTest'
import './styles/global.css'
function App() {
  return (
    <>
      <div className='container-app'>
        <div className="Header">
          <HeaderText />
        </div>
        {/* <Header /> */}
        <Box sx={{ paddingTop: '64px' }}>
          <Outlet />
        </Box>
      </div>
    </>
  )
}

export default App
