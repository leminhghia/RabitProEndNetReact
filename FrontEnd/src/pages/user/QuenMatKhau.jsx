import React from 'react'
import {
  Container,
  Box,
  Typography,
  TextField,
  Button,
  Paper,
  Link
} from '@mui/material'
import { NavLink } from 'react-router-dom'

const QuenMatKhau = () => {
  return (
    <Container component="main" maxWidth="xs">
      <Box
        sx={{
          marginTop: 8,
          display: 'flex',
          flexDirection: 'column',
          alignItems: 'center'
        }}
      >
        <Paper
          elevation={3}
          sx={{
            padding: 4,
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
            width: '100%'
          }}
        >
          <Typography component="h1" variant="h5">
            Quên Mật Khẩu
          </Typography>
          <Box component="form" sx={{ mt: 1 }}>
            <TextField
              margin="normal"
              required
              fullWidth
              id="email"
              label="Email"
              name="email"
              autoComplete="email"
              autoFocus
              helperText="Nhập email để lấy lại mật khẩu"
            />
            <Button
              type="submit"
              fullWidth
              variant="contained"
              sx={{ mt: 3, mb: 2 }}
            >
              Gửi yêu cầu
            </Button>
            <Box sx={{ textAlign: 'center' }}>
              <Link component={NavLink} to="/login" variant="body2">
                Quay lại đăng nhập
              </Link>
            </Box>
          </Box>
        </Paper>
      </Box>
    </Container>
  )
}

export default QuenMatKhau
