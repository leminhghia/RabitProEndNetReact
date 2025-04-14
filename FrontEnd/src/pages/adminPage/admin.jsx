import React from 'react'
import './Admin.css'
import { Outlet } from 'react-router-dom'
import HeaderAdmin from '../../Component/adminComponent/HeaderAdmin'
import { Box } from '@mui/material'
const Admin = () => {
  return (
    <div className="admin">
      <div className="headerAdmin">
        <HeaderAdmin />
      </div>
      <Box sx={{ paddingTop: '64px' }}>
        <Outlet />
      </Box>
    </div>
  )
}

export default Admin
