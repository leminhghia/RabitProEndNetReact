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
// import { styled } from '@mui/material/styles'
import BannerHome from '../../Component/slideShow/BannerHome'
import FlashSalePage from '../../Component/product/FlastSale'
import Categories from '../../Component/product/DanhMuc/Categories'
import BeGai from '../../Component/product/BeGai'
import BeTrai from '../../Component/product/BeTrai'
import DichVu from '../../Component/DichVu/DichVu'
import Blog from '../../Component/DichVu/Blog'
import Footer from '../../Component/Footer'

// const StyledBanner = styled(Box)(({ theme }) => ({
//   width: '100%',
//   height: 400,
//   backgroundColor: theme.palette.grey[100],
//   display: 'flex',
//   alignItems: 'center',
//   justifyContent: 'center',
//   borderRadius: theme.shape.borderRadius,
//   marginBottom: theme.spacing(4),
// }))

// const CategoryCard = styled(Paper)(({ theme }) => ({
//   padding: theme.spacing(3),
//   textAlign: 'center',
//   borderRadius: theme.shape.borderRadius,
//   transition: 'transform 0.2s',
//   '&:hover': {
//     transform: 'translateY(-4px)',
//     boxShadow: theme.shadows[4],
//   },
// }))

// const ProductCard = styled(Card)(({ theme }) => ({
//   height: '100%',
//   display: 'flex',
//   flexDirection: 'column',
//   transition: 'transform 0.2s',
//   '&:hover': {
//     transform: 'translateY(-4px)',
//     boxShadow: theme.shadows[4],
//   },
// }))

const HomePages = () => {
  return (
    <div>
      {' '}
      <BannerHome />
      <Container maxWidth={false} sx={{ maxWidth: '1250px', width: '100%' }}>
        {/*  */}
        <FlashSalePage />
        {/*  */}
        <Categories />
        {/*  */}
        <BeGai />
        {/*  */}
        <BeTrai />
        {/*  */}
        <DichVu />
        {/*  */}
        {/* <Blog /> */}
        {/*  */}
      </Container>
      <Footer />
    </div>
  )
}

export default HomePages
