import React, { useState } from 'react'
import {
  AppBar,
  Toolbar,
  Typography,
  TextField,
  IconButton,
  Menu,
  MenuItem,
  Badge,
  Box,
} from '@mui/material'
import SearchIcon from '@mui/icons-material/Search'
import PhoneIcon from '@mui/icons-material/Phone'
import AccountCircleIcon from '@mui/icons-material/AccountCircle'
import ShoppingCartIcon from '@mui/icons-material/ShoppingCart'
import ArrowDropDownIcon from '@mui/icons-material/ArrowDropDown'
import { Link } from 'react-router-dom'

const HeaderText = () => {
  const [anchorEl, setAnchorEl] = useState(null)
  const [menuType, setMenuType] = useState('')
  const [accountMenuAnchor, setAccountMenuAnchor] = useState(null)

  const handleMenuOpen = (event, type) => {
    setAnchorEl(event.currentTarget)
    setMenuType(type)
  }

  const handleMenuClose = () => {
    setAnchorEl(null)
    setMenuType('')
  }

  const handleAccountMenuOpen = (event) => {
    setAccountMenuAnchor(event.currentTarget)
  }

  const handleAccountMenuClose = () => {
    setAccountMenuAnchor(null)
  }

  const menuItems = {
    'Bé gái': [
      { label: 'Áo bé gái', link: '/product' },
      { label: 'Quần bé gái', link: '/product' },
      { label: 'Váy bé gái', link: '/product' },
    ],
    'Bé trai': [
      { label: 'Áo bé trai', link: '/product' },
      { label: 'Quần bé trai', link: '/product' },
      { label: 'Phụ kiện bé trai', link: '/product' },
    ],
    'Bộ sưu tập': [
      { label: 'BST Mùa Hè', link: '/' },
      { label: 'BST Mùa Đông', link: '/' },
    ],
    'Ưu đãi tháng 4': [
      { label: 'Ưu đãi 1', link: '/' },
      { label: 'Ưu đãi 2', link: '/' },
    ],
    'New Arrival': [
      { label: 'Sản phẩm mới 1', link: '/' },
      { label: 'Sản phẩm mới 2', link: '/' },
    ],
    'Sale up to 50%+': [
      { label: 'Sale 50%', link: '/' },
      { label: 'Sale 70%', link: '/' },
    ],
    'Cửa hàng': [
      { label: 'Cửa hàng 1', link: '/' },
      { label: 'Cửa hàng 2', link: '/' },
    ],
    'Tin tức': [
      { label: 'Tin tức 1', link: '/about' },
      { label: 'Tin tức 2', link: '/about' },
    ],
  }

  return (
    <AppBar position="static" color="default" elevation={1}>
      {/* Top Row: Logo, Search Bar, Contact Info, Icons */}
      <Toolbar
        sx={{
          justifyContent: 'space-between',
          py: 1,
          px: '100px',
          width: '100%',
        }}
      >
        {/* Logo */}
        <Box sx={{ display: 'flex', alignItems: 'center', ml: 2 }}>
          <Link to="/">
            <img
              src="https://placehold.co/100x40?text=Rabbity"
              alt="Rabbity Logo"
              style={{ height: '40px' }}
            />
          </Link>
        </Box>

        {/* Search Bar */}
        <Box sx={{ display: 'flex', justifyContent: 'center', my: 2 }}>
          <TextField
            size="small"
            placeholder="Tìm kiếm..."
            sx={{ width: 500 }}
            InputProps={{
              endAdornment: <SearchIcon />,
            }}
          />
        </Box>

        {/* Contact Info */}
        <Box sx={{ display: 'flex', alignItems: 'center', mr: 2 }}>
          <IconButton sx={{ p: 0.5 }}>
            <PhoneIcon />
          </IconButton>
          <Typography variant="body2" sx={{ mx: 1 }}>
            19006633520
          </Typography>
          <Typography variant="body2" sx={{ cursor: 'pointer', ml: 2 }}>
            Kiểm tra đơn hàng
          </Typography>
        </Box>
      </Toolbar>

      {/* Bottom Row: Navigation Menu */}
      <Box
        sx={{
          display: 'flex',
          justifyContent: 'space-between',
          alignItems: 'center',
          py: 0.5,
          px: 2,
        }}
      >
        {/* Menu Items */}
        <Box sx={{ display: 'flex', justifyContent: 'center', flexGrow: 1 }}>
          {Object.keys(menuItems).map((item) => (
            <Box key={item} sx={{ mx: 2 }}>
              <Typography
                variant="body1"
                sx={{
                  cursor: 'pointer',
                  display: 'flex',
                  alignItems: 'center',
                }}
                onClick={(e) => handleMenuOpen(e, item)}
              >
                {item} <ArrowDropDownIcon fontSize="small" />
              </Typography>
              <Menu
                anchorEl={anchorEl}
                open={menuType === item && Boolean(anchorEl)}
                onClose={handleMenuClose}
              >
                {menuItems[item].map((subItem) => (
                  <MenuItem key={subItem.label} onClick={handleMenuClose}>
                    <Link
                      to={subItem.link}
                      style={{ textDecoration: 'none', color: 'inherit' }}
                    >
                      {subItem.label}
                    </Link>
                  </MenuItem>
                ))}
              </Menu>
            </Box>
          ))}
        </Box>

        {/* Right Icons (Search, User, Cart) */}
        <Box sx={{ display: 'flex', alignItems: 'center' }}>
          <IconButton sx={{ mx: 0.5 }}>
            <SearchIcon />
          </IconButton>
          <IconButton sx={{ mx: 0.5 }} onClick={handleAccountMenuOpen}>
            <AccountCircleIcon />
          </IconButton>
          <Menu
            anchorEl={accountMenuAnchor}
            open={Boolean(accountMenuAnchor)}
            onClose={handleAccountMenuClose}
          >
            <MenuItem onClick={handleAccountMenuClose}>
              <Link to="/login" style={{ textDecoration: 'none', color: 'inherit' }}>
                Đăng nhập
              </Link>
            </MenuItem>
            <MenuItem onClick={handleAccountMenuClose}>
              <Link to="/register" style={{ textDecoration: 'none', color: 'inherit' }}>
                Đăng ký
              </Link>
            </MenuItem>
          </Menu>
          <IconButton sx={{ mx: 0.5 }}>
            <Badge badgeContent={0} color="error">
              <ShoppingCartIcon />
            </Badge>
          </IconButton>
        </Box>
      </Box>
    </AppBar>
  )
}

export default HeaderText
