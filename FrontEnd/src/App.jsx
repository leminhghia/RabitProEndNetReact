import { NavLink, Outlet } from 'react-router-dom'

import Box from '@mui/material/Box'
import Header from './Component/header'

function App() {
	
  return (
    <>
      <div>
        <Header />
        <Box sx={{ paddingTop: '64px' }}>
          {/* <nav style={navStyle}>
            <NavLink
              to="/"
              style={linkStyle}
              className={({ isActive }) => (isActive ? 'active' : '')}
            >
              Trang chủ
            </NavLink>
            <NavLink
              to="/about"
              style={linkStyle}
              className={({ isActive }) => (isActive ? 'active' : '')}
            >
              Về chúng tôi
            </NavLink>
          </nav> */}
          <Outlet />
        </Box>
      </div>
    </>
  )
}

export default App

// const navStyle = {
//   display: 'flex',
//   gap: '20px',
//   padding: '10px 20px',
//   backgroundColor: '#f5f5f5',
//   borderBottom: '1px solid #ddd',
// }

// const linkStyle = {
//   textDecoration: 'none',
//   color: '#333',
//   fontWeight: '500',
//   padding: '5px 10px',
// }
