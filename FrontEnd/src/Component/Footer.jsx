// src/components/Footer.jsx
import React from 'react'
import {
  Box,
  Container,
  Grid,
  Typography,
  TextField,
  Button,
  IconButton,
  Link,
} from '@mui/material'
import FacebookIcon from '@mui/icons-material/Facebook'
import LocationOnIcon from '@mui/icons-material/LocationOn'
import PhoneIcon from '@mui/icons-material/Phone'
import EmailIcon from '@mui/icons-material/Email'
import SvgIcon from '@mui/material/SvgIcon'

// Nếu cần icon TikTok, bạn có thể dùng SvgIcon với path SVG tương ứng
const TikTokIcon = (props) => (
  <SvgIcon {...props}>
    <path d="M12 2C6.48 2 2 6.48 2 12c0 4.99 3.66 9.12 8.44 9.88v-6.99H8.1v-2.9h2.34V9.41c0-2.32 1.38-3.59 3.5-3.59.99 0 1.84.07 2.09.1v2.42h-1.43c-1.12 0-1.33.53-1.33 1.3v1.72h2.66l-.35 2.9h-2.31V22C18.34 21.12 22 16.99 22 12c0-5.52-4.48-10-10-10z" />
  </SvgIcon>
)

export default function Footer() {
  return (
    <Box component="footer" sx={{ backgroundColor: 'grey.100', pt: 6, pb: 4 }}>
      <Container maxWidth="lg">
        <Grid container spacing={4}>
          {/* Logo + mô tả + newsletter + social */}
          <Grid item xs={12} md={4}>
            <Box
              component="img"
              src="/assets/logo.png"
              alt="Rabity Logo"
              sx={{ width: 120, mb: 2 }}
            />
            <Typography variant="body2" paragraph>
              Rabity là thương hiệu thời trang trẻ em hàng đầu Việt Nam với hơn
              60 showroom trên toàn quốc, mang đến cho bé những bộ quần áo thoải
              mái cho bé “tự do khám phá” thế giới và trải nghiệm niềm vui mỗi
              ngày.
            </Typography>
            <Typography variant="h6" gutterBottom>
              ĐĂNG KÝ NHẬN TIN
            </Typography>
            <Box sx={{ display: 'flex', mb: 2 }}>
              <TextField
                placeholder="Nhập địa chỉ email"
                variant="outlined"
                size="small"
                fullWidth
                sx={{
                  '& .MuiOutlinedInput-root': {
                    borderRadius: '50px 0 0 50px',
                  },
                }}
              />
              <Button
                variant="contained"
                sx={{
                  borderRadius: '0 50px 50px 0',
                  backgroundColor: 'text.primary',
                  color: 'common.white',
                  px: 3,
                }}
              >
                Đăng ký
              </Button>
            </Box>
            <Box>
              <IconButton aria-label="facebook">
                <FacebookIcon />
              </IconButton>
              <IconButton aria-label="tiktok">
                <TikTokIcon />
              </IconButton>
            </Box>
          </Grid>

          {/* Cột Về Rabity */}
          <Grid item xs={6} md={2}>
            <Typography variant="h6" gutterBottom>
              VỀ RABITY
            </Typography>
            <Link href="#" underline="none" display="block" sx={{ mb: 0.5 }}>
              Giới thiệu về Rabity
            </Link>
            <Link href="#" underline="none" display="block">
              Tin tức Rabity
            </Link>
          </Grid>

          {/* Cột Hỗ trợ khách hàng */}
          <Grid item xs={6} md={2}>
            <Typography variant="h6" gutterBottom>
              HỖ TRỢ KHÁCH HÀNG
            </Typography>
            {[
              'Chính sách đổi trả hàng',
              'Tra cứu đơn hàng',
              'Hướng dẫn chọn size',
              'Giao hàng & phí giao hàng',
              'Chính sách Khách hàng thân thiết',
              'Chính sách bảo mật thông tin',
              'Chính sách đại lý',
            ].map((text) => (
              <Link
                key={text}
                href="#"
                underline="none"
                display="block"
                sx={{ mb: 0.5 }}
              >
                {text}
              </Link>
            ))}
          </Grid>

          {/* Cột Công ty TNHH Tân Phú */}
          <Grid item xs={12} md={4}>
            <Typography variant="h6" gutterBottom>
              CÔNG TY TNHH TÂN PHÚ
            </Typography>
            <Box sx={{ display: 'flex', mb: 1 }}>
              <LocationOnIcon fontSize="small" />
              <Box sx={{ ml: 1 }}>
                <Typography variant="body2">
                  Văn phòng phía Bắc: 378 Lĩnh Nam, Phường Trần Phú, Quận Hoàng
                  Mai, TP Hà Nội
                </Typography>
                <Typography variant="body2">
                  Văn phòng phía Nam: Số 33 đường 12A, Lake View City, Phường An
                  Phú, Quận 2, TP HCM
                </Typography>
              </Box>
            </Box>
            <Box sx={{ display: 'flex', alignItems: 'center', mb: 1 }}>
              <PhoneIcon fontSize="small" />
              <Typography variant="body2" sx={{ ml: 1 }}>
                1900633520
              </Typography>
            </Box>
            <Box sx={{ display: 'flex', alignItems: 'center' }}>
              <EmailIcon fontSize="small" />
              <Typography variant="body2" sx={{ ml: 1 }}>
                cskh@rabity.vn
              </Typography>
            </Box>
          </Grid>
        </Grid>

        {/* Hàng badge chứng nhận + phương thức thanh toán */}
        <Box
          sx={{
            mt: 4,
            display: 'flex',
            justifyContent: 'space-between',
            alignItems: 'center',
            flexWrap: 'wrap',
          }}
        >
          {/* chứng nhận */}
          <Box sx={{ display: 'flex', alignItems: 'center', mb: 2 }}>
            {[
              { src: '/assets/bct.png', alt: 'Bộ Công Thương' },
              { src: '/assets/dmca.png', alt: 'DMCA' },
              { src: '/assets/ncsc.png', alt: 'NCSC' },
            ].map((img) => (
              <Box
                key={img.alt}
                component="img"
                src={img.src}
                alt={img.alt}
                sx={{ height: 32, mr: 1 }}
              />
            ))}
          </Box>

          {/* thanh toán */}
          <Box sx={{ display: 'flex', alignItems: 'center', mb: 2 }}>
            {[
              { src: '/assets/visa.png', alt: 'Visa' },
              { src: '/assets/mastercard.png', alt: 'Mastercard' },
              { src: '/assets/momo.png', alt: 'MoMo' },
              { src: '/assets/zalopay.png', alt: 'ZaloPay' },
              { src: '/assets/cod.png', alt: 'COD' },
            ].map((img) => (
              <Box
                key={img.alt}
                component="img"
                src={img.src}
                alt={img.alt}
                sx={{ height: 32, mr: 1 }}
              />
            ))}
          </Box>
        </Box>
      </Container>
    </Box>
  )
}
