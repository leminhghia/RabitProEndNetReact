import * as React from 'react'
import { Link } from 'react-router-dom'
import { assets } from '../../assets/Admin/assets'
import Button from '@mui/material/Button'
import MenuOpenIcon from '@mui/icons-material/MenuOpen'
import SearchAdmin from './SearchAdmin'
import {
  MdOutlineLightMode,
  MdOutlineShoppingCart,
  MdOutlineEmail,
} from 'react-icons/md'
import { FaRegBell } from 'react-icons/fa'
import Menu from '@mui/material/Menu'
import MenuItem from '@mui/material/MenuItem'
import ListItemIcon from '@mui/material/ListItemIcon'
import Divider from '@mui/material/Divider'
import Logout from '@mui/icons-material/Logout'
import PersonAdd from '@mui/icons-material/PersonAdd'
import { FaShieldHalved } from 'react-icons/fa6'

const HeaderAdmin = () => {
  const [accountAnchorEl, setAccountAnchorEl] = React.useState(null)
  const [notificationAnchorEl, setNotificationAnchorEl] = React.useState(null)
  const [cartAnchorEl, setCartAnchorEl] = React.useState(null)
  const [emailAnchorEl, setEmailAnchorEl] = React.useState(null)

  const openMyAcc = Boolean(accountAnchorEl)
  const openNotification = Boolean(notificationAnchorEl)
  const openCart = Boolean(cartAnchorEl)
  const openEmail = Boolean(emailAnchorEl)

  const handleOpenMyAccDr = (event) => {
    setAccountAnchorEl(event.currentTarget)
  }
  const handleCloseMyAccDr = () => {
    setAccountAnchorEl(null)
  }

  const handleOpennotificationDrop = (event) => {
    setNotificationAnchorEl(event.currentTarget)
  }
  const handleClosenotificationDrop = () => {
    setNotificationAnchorEl(null)
  }

  const handleOpenCart = (event) => {
    setCartAnchorEl(event.currentTarget)
  }
  const handleCloseCart = () => {
    setCartAnchorEl(null)
  }

  const handleOpenEmail = (event) => {
    setEmailAnchorEl(event.currentTarget)
  }
  const handleCloseEmail = () => {
    setEmailAnchorEl(null)
  }

  return (
    <div className="masterHeader d-flex align-items-center">
      <div className="container-fluid w-100">
        <div className="row d-flex align-items-center">
          <div className="d-flex align-items-center w-100">
            {/* Logo */}
            <div className="part1 col-sm-2">
              <Link
                to={'/admin'}
                className="d-flex align-items-center logo text-decoration-none"
              >
                <img
                  src={assets.LogoAdmin}
                  alt="Logo"
                  style={{ height: '40px' }}
                />
                <span className="ms-2 fw-bold text-dark">NOVA-SHOP</span>
              </Link>
            </div>

            {/* Menu button + Search */}
            <div className="part2 col-ms-3 d-flex align-items-center">
              <Button className="rounded-circle me-3">
                <MenuOpenIcon />
              </Button>
              <SearchAdmin />
            </div>

            {/* Right icons */}
            <div className="part3 col-sm-7 d-flex align-items-center justify-content-end">
              <Button className="rounded-circle me-3">
                <MdOutlineLightMode />
              </Button>

              {/* Cart Dropdown */}
              <div className="dropdownWrapper position-relative">
                <Button
                  className="rounded-circle me-3"
                  onClick={handleOpenCart}
                  aria-controls={openCart ? 'cart-menu' : undefined}
                  aria-haspopup="true"
                  aria-expanded={openCart ? 'true' : undefined}
                >
                  <MdOutlineShoppingCart />
                </Button>
                <Menu
                  anchorEl={cartAnchorEl}
                  id="cart-menu"
                  open={openCart}
                  onClose={handleCloseCart}
                  onClick={handleCloseCart}
                  anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
                  transformOrigin={{ vertical: 'top', horizontal: 'right' }}
                  PaperProps={{
                    sx: {
                      minWidth: 250,
                      borderRadius: 2,
                      p: 1,
                      marginTop: '10px',
                    },
                  }}
                >
                  <MenuItem disabled>Cart is empty</MenuItem>
                  <Divider />
                  <MenuItem onClick={handleCloseCart}>
                    <ListItemIcon>
                      <MdOutlineShoppingCart />
                    </ListItemIcon>
                    Go to Cart
                  </MenuItem>
                </Menu>
              </div>

              {/* Email Dropdown */}
              <div className="dropdownWrapper position-relative">
                <Button
                  className="rounded-circle me-3"
                  onClick={handleOpenEmail}
                  aria-controls={openEmail ? 'email-menu' : undefined}
                  aria-haspopup="true"
                  aria-expanded={openEmail ? 'true' : undefined}
                >
                  <MdOutlineEmail />
                </Button>
                <Menu
                  anchorEl={emailAnchorEl}
                  id="email-menu"
                  open={openEmail}
                  onClose={handleCloseEmail}
                  onClick={handleCloseEmail}
                  anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
                  transformOrigin={{ vertical: 'top', horizontal: 'right' }}
                  PaperProps={{
                    sx: {
                      minWidth: 250,
                      borderRadius: 2,
                      p: 1,
                      marginTop: '10px',
                    },
                  }}
                >
                  <MenuItem disabled>No new messages</MenuItem>
                  <Divider />
                  <MenuItem onClick={handleCloseEmail}>
                    <ListItemIcon>
                      <MdOutlineEmail />
                    </ListItemIcon>
                    Go to Inbox
                  </MenuItem>
                </Menu>
              </div>

              {/* Notification Dropdown */}
              <div className="dropdownWrapper position-relative">
                <Button
                  className="rounded-circle me-3"
                  onClick={handleOpennotificationDrop}
                  aria-controls={
                    openNotification ? 'notification-menu' : undefined
                  }
                  aria-haspopup="true"
                  aria-expanded={openNotification ? 'true' : undefined}
                >
                  <FaRegBell />
                </Button>
                <Menu
                  anchorEl={notificationAnchorEl}
                  className="notification-menu"
                  id="notification-menu"
                  open={openNotification}
                  onClose={handleClosenotificationDrop}
                  onClick={handleClosenotificationDrop}
                  anchorOrigin={{ vertical: 'bottom', horizontal: 'right' }}
                  transformOrigin={{ vertical: 'top', horizontal: 'right' }}
                  PaperProps={{
                    sx: {
                      minWidth: 300,
                      borderRadius: 2,
                      p: 1,
                      marginTop: '10px',
                    },
                  }}
                >
                  <Divider />
                  <MenuItem onClick={handleClosenotificationDrop}>
                    <ListItemIcon>
                      <PersonAdd fontSize="small" />
                    </ListItemIcon>
                    My Notification
                  </MenuItem>
                  <MenuItem onClick={handleClosenotificationDrop}>
                    <ListItemIcon>
                      <FaShieldHalved />
                    </ListItemIcon>
                    Reset Password
                  </MenuItem>
                  <MenuItem onClick={handleClosenotificationDrop}>
                    <ListItemIcon>
                      <Logout fontSize="small" />
                    </ListItemIcon>
                    Logout
                  </MenuItem>
                </Menu>
              </div>

              {/* My Account Dropdown */}
              <div className="myAccWrapper">
                <Button
                  className="myAcc d-flex align-items-center"
                  onClick={handleOpenMyAccDr}
                >
                  <div className="userImg">
                    <span className="rounded-circle">
                      <img
                        src="https://mironcoder-hotash.netlify.app/images/avatar/01.webp"
                        alt="avatar"
                      />
                    </span>
                  </div>
                  <div className="userInfo ms-2">
                    <h4 className="mb-0">Hoang Nhan</h4>
                    <p className="mb-0">@nhan123</p>
                  </div>
                </Button>
                <Menu
                  anchorEl={accountAnchorEl}
                  id="account-menu"
                  open={openMyAcc}
                  onClose={handleCloseMyAccDr}
                  onClick={handleCloseMyAccDr}
                  transformOrigin={{ horizontal: 'right', vertical: 'top' }}
                  anchorOrigin={{ horizontal: 'right', vertical: 'bottom' }}
                >
                  <Divider />
                  <MenuItem onClick={handleCloseMyAccDr}>
                    <ListItemIcon>
                      <PersonAdd fontSize="small" />
                    </ListItemIcon>
                    My Account
                  </MenuItem>
                  <MenuItem onClick={handleCloseMyAccDr}>
                    <ListItemIcon>
                      <FaShieldHalved />
                    </ListItemIcon>
                    Reset Password
                  </MenuItem>
                  <MenuItem onClick={handleCloseMyAccDr}>
                    <ListItemIcon>
                      <Logout fontSize="small" />
                    </ListItemIcon>
                    Logout
                  </MenuItem>
                </Menu>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}

export default HeaderAdmin
