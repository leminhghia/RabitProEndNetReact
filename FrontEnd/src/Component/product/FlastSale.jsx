import React from 'react'
import { Box, Typography, Button } from '@mui/material'
import Slider from 'react-slick' // Import react-slick
import ProductCard from '../../pages/product/ProductCard'
import 'slick-carousel/slick/slick.css' // Import CSS của slick
import 'slick-carousel/slick/slick-theme.css' // Import theme CSS của slick

const FlashSalePage = () => {
  const sanPham = [
    {
      image: 'https://via.placeholder.com/300x200',
      discount: '-20%',
      new: true,
      bannerText: 'TẶNG KÈO XỊN - GIẢM 50K',
      description: 'Đồ bộ thun sát nách bé trai Rabity...',
      originalPrice: 299000,
      discountedPrice: 269100,
      icons: [{ color: 'black' }, { color: 'pink' }],
    },
    {
      image: 'https://via.placeholder.com/300x200',
      discount: '-20%',
      new: true,
      bannerText: 'MUA 1 GIẢM 10K - MUA 2 GIẢM 30K',
      description: 'Đồ chơi Online] Đồ bộ thun ngắn...',
      originalPrice: 239000,
      discountedPrice: 191200,
      icons: [{ color: 'pink' }],
    },
    {
      image: 'https://via.placeholder.com/300x200',
      discount: '-20%',
      new: true,
      bannerText: 'MUA 1 GIẢM 10K - MUA 2 GIẢM 30K',
      description: 'Đồ bộ thun ngắn tay Spider-Man bé...',
      originalPrice: 239000,
      discountedPrice: 191200,
      icons: [{ color: 'red' }],
    },
    {
      image: 'https://via.placeholder.com/300x200',
      discount: '-20%',
      new: true,
      bannerText: 'MUA 1 GIẢM 10K - MUA 2 GIẢM 30K',
      description: 'Đầm váy thon gọn...',
      originalPrice: 199000,
      discountedPrice: 159200,
      icons: [{ color: 'pink' }],
    },
  ]

  // Cấu hình cho Slider
  const settings = {
    dots: false, // Ẩn các dấu chấm (dots)
    infinite: true, // Lặp vô hạn
    speed: 500, // Tốc độ chuyển slide (ms)
    slidesToShow: 4, // Hiển thị 4 sản phẩm cùng lúc
    slidesToScroll: 1, // Mỗi lần trượt sẽ chuyển 1 sản phẩm
    autoplay: true, // Tự động trượt
    autoplaySpeed: 3000, // Thời gian giữa các lần trượt (ms)
    arrows: true, // Hiển thị nút điều hướng (mũi tên trái/phải)
    responsive: [
      {
        breakpoint: 1024, // Dưới 1024px
        settings: {
          slidesToShow: 3, // Hiển thị 3 sản phẩm
          slidesToScroll: 1,
        },
      },
      {
        breakpoint: 600, // Dưới 600px
        settings: {
          slidesToShow: 2, // Hiển thị 2 sản phẩm
          slidesToScroll: 1,
        },
      },
      {
        breakpoint: 480, // Dưới 480px
        settings: {
          slidesToShow: 1, // Hiển thị 1 sản phẩm
          slidesToScroll: 1,
        },
      },
    ],
  }

  return (
    <Box
      sx={{
        position: 'relative',
        padding: 2,
        backgroundColor: 'white',
        width: '100%',
      }}
    >
      {/* Tiêu đề */}
      <h2>DEAL HOT GIỜ VÀNG</h2>
      <Box
        sx={{
          borderBottom: '1px solid black',
          padding: '10px',
        }}
      >
        <Typography variant="h6">Ưu đãi trong 4</Typography>
      </Box>
      {/* Slideshow sản phẩm */}
      <Box sx={{ marginTop: 2, width: '100%' }}>
        <Slider {...settings}>
          {sanPham.map((sanPham, index) => (
            <Box
              key={index}
              sx={{
                padding: '0 5px', // Khoảng cách nhỏ giữa các sản phẩm
              }}
            >
              <ProductCard product={sanPham} />
            </Box>
          ))}
        </Slider>
      </Box>

      {/* Nút kêu gọi hành động */}
      <Box sx={{ textAlign: 'center', marginTop: 2 }}>
        <Button
          sx={{
            backgroundColor: 'gray',
            color: 'white',
            '&:hover': { backgroundColor: '#555' },
          }}
        >
          Xem thêm
        </Button>
      </Box>
    </Box>
  )
}

export default FlashSalePage
