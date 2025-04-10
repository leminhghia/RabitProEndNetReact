import React, { useState, useEffect } from 'react'
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

const Register = () => {
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  const [error, setError] = useState('')
  const [loading, setLoading] = useState(false)
  const navigate = useNavigate()

  useEffect(() => {
    if (email && password) {
      console.log('Email:', email)
      console.log('Password:', password)
    }
  }, [email, password])

  const handleRegister = async (event) => {
    event.preventDefault()
    if (!email || !password) {
      setError('Vui lòng nhập đầy đủ thông tin')
      return
    }

    // const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    // if (!emailRegex.test(email)) {
    //   setError('Email không hợp lệ!')
    //   return
    // }
    setLoading(true)
    setError('')
    try {
      const response = await axios.post(
        'https://localhost:5001/api/taikhoan/register',
        { email, password },
        { headers: { 'Content-Type': 'application/json' } }
      )
      if (response.status === 200) {
        alert('Đăng ký thành công!')
        navigate('/login')
      }
    } catch (error) {
      console.error('Lỗi đăng ký:', error)
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
              disabled={loading}
            >
              {loading ? 'Đang xử lý...' : 'Đăng ký'}
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
