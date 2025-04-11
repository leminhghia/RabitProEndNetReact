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
import axios from 'axios'

const Login = () => {
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  const [loading, setLoading] = useState(false)
  const navigate = useNavigate()

  const handleLogin = async (event) => {
    event.preventDefault()

    if (!email || !password) {
      alert('Vui lòng nhập email và mật khẩu')
      return
    }

    setLoading(true)
    try {
      const response = await axios.post(
        'https://localhost:5001/api/login',
        { email, password },
        { headers: { 'Content-Type': 'application/json' } }
      )

      if (response.status === 200) {
        alert('Đăng nhập thành công!')
        navigate('/')
      }
    } catch (error) {
      console.error('Lỗi đăng nhập:', error)
      if (error.response) {
        if (error.response.status === 401) {
          alert('Sai email hoặc mật khẩu!')
        } else if (error.response.status === 400) {
          alert(
            'Dữ liệu không hợp lệ! Vui lòng kiểm tra lại email và mật khẩu.'
          )
        } else {
          alert('Đã xảy ra lỗi từ server! Vui lòng thử lại sau.')
        }
      } else if (error.request) {
        alert(
          'Không thể kết nối đến server! Vui lòng kiểm tra kết nối mạng hoặc server.'
        )
      } else {
        alert('Đã xảy ra lỗi không xác định! Vui lòng thử lại.')
      }
    } finally {
      setLoading(false)
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
            Đăng nhập
          </Typography>
          <Box component="form" sx={{ mt: 1 }} onSubmit={handleLogin}>
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
              autoComplete="current-password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
            <Button
              type="submit"
              fullWidth
              variant="contained"
              sx={{ mt: 3, mb: 2 }}
              disabled={loading}
            >
              {loading ? 'Đang xử lý...' : 'Đăng nhập'}
            </Button>
          </Box>
        </Paper>
      </Box>
    </Container>
  )
}

export default Login
