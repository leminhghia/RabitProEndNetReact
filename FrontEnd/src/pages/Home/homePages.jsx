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
