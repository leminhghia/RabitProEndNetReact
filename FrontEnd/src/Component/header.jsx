import { AppBar, Button, Toolbar, Typography } from '@mui/material'
import React from 'react'
import { Link } from 'react-router-dom'
import ThemeToggle from './ThemeToggle'

const Header = () => {
  return (
    <AppBar
      position="fixed"
      sx={{ zIndex: (theme) => theme.zIndex.drawer + 1 }}
    >
      <Toolbar>
        <Button color="inherit" component={Link} to="/">
          Home
        </Button>
        <Button color="inherit" component={Link} to="/about">
          About
        </Button>
        <Button color="inherit" component={Link} to="/login">
          login
        </Button>
        <ThemeToggle />
        <Typography
          variant="h6"
          component="div"
          sx={{ flexGrow: 1, textAlign: 'right' }}
        >
          My App
        </Typography>
      </Toolbar>
    </AppBar>
  )
}

export default Header
