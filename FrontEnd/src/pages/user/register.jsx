import React, { useState } from 'react'
import {
  Container,
  Box,
  Typography,
  TextField,
  Button,
  Paper,
} from '@mui/material'
import { NavLink, useNavigate } from 'react-router-dom'
import { useDispatch, useSelector } from 'react-redux'
import {
  clearError,
  registerUser,
} from '../../redux/slices/TaiKhoan/loginSlice'

const Register = () => {
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  const dispatch = useDispatch()
  const navigate = useNavigate()

  // Lấy trạng thái loading và error từ Redux store
  const { isLoading, error } = useSelector((state) => state.login)

  const handleRegister = async (e) => {
    e.preventDefault()
    // Xóa thông báo lỗi cũ nếu có
    dispatch(clearError())
    try {
      const resultAction = await dispatch(registerUser({ email, password }))
      if (registerUser.fulfilled.match(resultAction)) {
        // Sau khi đăng ký thành công, có thể điều hướng đến trang đăng nhập hoặc trang khác
        navigate('/login')
      }
    } catch (err) {
      console.error('Đăng ký thất bại:', err)
    }
  }

  return (
    <Container component="main" maxWidth="xs">
      <Box
        sx={{
          marginTop: 8,
          display: 'flex',
          flexDirection: 'column',
          alignItems: 'center',
        }}
      >
        <Paper
          elevation={3}
          sx={{ padding: 4, width: '100%', textAlign: 'center' }}
        >
          <Typography component="h1" variant="h5">
            Đăng ký
          </Typography>
          <Box component="form" sx={{ mt: 1 }} onSubmit={handleRegister}>
            <TextField
              margin="normal"
              required
              fullWidth
              label="Email"
              autoComplete="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />
            <TextField
              margin="normal"
              required
              fullWidth
              label="Mật khẩu"
              type="password"
              autoComplete="new-password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
            {error && (
              <Typography color="error" variant="body2" sx={{ mt: 1 }}>
                {error}
              </Typography>
            )}
            <Button
              type="submit"
              fullWidth
              variant="contained"
              sx={{ mt: 3, mb: 2 }}
              disabled={isLoading}
            >
              {isLoading ? 'Đang xử lý...' : 'Đăng ký'}
            </Button>
            <Box sx={{ textAlign: 'center' }}>
              <NavLink to="/login">{'Đã có tài khoản? Đăng nhập'}</NavLink>
            </Box>
          </Box>
        </Paper>
      </Box>
    </Container>
  )
}

export default Register
