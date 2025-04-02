import React from 'react'
import {
  Box,
  Container,
  Typography,
  Grid,
  Paper,
  Card,
  CardContent,
  CardMedia,
} from '@mui/material'
import { styled } from '@mui/material/styles'

const StyledBanner = styled(Box)(({ theme }) => ({
  width: '100%',
  height: 400,
  backgroundColor: theme.palette.grey[100],
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'center',
  borderRadius: theme.shape.borderRadius,
  marginBottom: theme.spacing(4),
}))

const CategoryCard = styled(Paper)(({ theme }) => ({
  padding: theme.spacing(3),
  textAlign: 'center',
  borderRadius: theme.shape.borderRadius,
  transition: 'transform 0.2s',
  '&:hover': {
    transform: 'translateY(-4px)',
    boxShadow: theme.shadows[4],
  },
}))

const ProductCard = styled(Card)(({ theme }) => ({
  height: '100%',
  display: 'flex',
  flexDirection: 'column',
  transition: 'transform 0.2s',
  '&:hover': {
    transform: 'translateY(-4px)',
    boxShadow: theme.shadows[4],
  },
}))

const HomePages = () => {
  return (
    <Container maxWidth="lg">
      {/* Banner Section */}
      <StyledBanner>
        <Typography variant="h3" component="h1">
          Banner Quảng Cáo
        </Typography>
      </StyledBanner>

      {/* Categories Section */}
      <Box mb={6}>
        <Typography variant="h4" component="h2" gutterBottom>
          Danh Mục Sản Phẩm
        </Typography>
        <Grid container spacing={3}>
          <Grid item xs={12} sm={4}>
            <CategoryCard elevation={2}>
              <Typography variant="h5">Điện Thoại</Typography>
            </CategoryCard>
          </Grid>
          <Grid item xs={12} sm={4}>
            <CategoryCard elevation={2}>
              <Typography variant="h5">Laptop</Typography>
            </CategoryCard>
          </Grid>
          <Grid item xs={12} sm={4}>
            <CategoryCard elevation={2}>
              <Typography variant="h5">Phụ Kiện</Typography>
            </CategoryCard>
          </Grid>
        </Grid>
      </Box>

      {/* Products Section */}
      <Box mb={6}>
        <Typography variant="h4" component="h2" gutterBottom>
          Sản Phẩm Nổi Bật
        </Typography>
        <Grid container spacing={3}>
          <Grid item xs={12} sm={6} md={4}>
            <ProductCard>
              <CardMedia
                component="div"
                sx={{ height: 200, backgroundColor: 'grey.100' }}
              />
              <CardContent>
                <Typography variant="h6" gutterBottom>
                  iPhone 13 Pro
                </Typography>
                <Typography variant="body1" color="primary">
                  25.000.000 đ
                </Typography>
              </CardContent>
            </ProductCard>
          </Grid>
          <Grid item xs={12} sm={6} md={4}>
            <ProductCard>
              <CardMedia
                component="div"
                sx={{ height: 200, backgroundColor: 'grey.100' }}
              />
              <CardContent>
                <Typography variant="h6" gutterBottom>
                  MacBook Pro
                </Typography>
                <Typography variant="body1" color="primary">
                  35.000.000 đ
                </Typography>
              </CardContent>
            </ProductCard>
          </Grid>
          <Grid item xs={12} sm={6} md={4}>
            <ProductCard>
              <CardMedia
                component="div"
                sx={{ height: 200, backgroundColor: 'grey.100' }}
              />
              <CardContent>
                <Typography variant="h6" gutterBottom>
                  AirPods Pro
                </Typography>
                <Typography variant="body1" color="primary">
                  5.000.000 đ
                </Typography>
              </CardContent>
            </ProductCard>
          </Grid>
        </Grid>
      </Box>
    </Container>
  )
}

export default HomePages
