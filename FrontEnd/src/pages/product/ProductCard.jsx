import React from 'react'
import {
  Card,
  CardMedia,
  CardContent,
  Typography,
  Badge,
  Box,
} from '@mui/material'

const ProductCard = ({ product }) => {
  return (
    <Card
      sx={{
        border: '2px solid orange',
        borderRadius: '10px',
        boxShadow: 'none',
      }}
    >
      {/* Hình ảnh và Badges */}
      <Box sx={{ position: 'relative' }}>
        <CardMedia
          component="img"
          image={product.image}
          alt={product.description}
          sx={{ height: 200, objectFit: 'cover' }}
        />
        {product.new && (
          <Badge
            badgeContent="Mới"
            sx={{
              position: 'absolute',
              top: 10,
              left: 10,
              '& .MuiBadge-badge': {
                backgroundColor: 'orange',
                color: 'white',
              },
            }}
          />
        )}
        <Badge
          badgeContent={product.discount}
          sx={{
            position: 'absolute',
            top: 10,
            right: 10,
            '& .MuiBadge-badge': { backgroundColor: 'red', color: 'white' },
          }}
        />
      </Box>

      {/* Nội dung thẻ */}
      <CardContent>
        <Typography
          sx={{
            backgroundColor: 'orange',
            color: 'white',
            padding: '5px',
            textAlign: 'center',
            borderRadius: '5px',
          }}
        >
          {product.bannerText}
        </Typography>
        <Typography variant="body2" sx={{ marginTop: 1 }}>
          {product.description}
        </Typography>
        <Typography
          variant="body2"
          sx={{ textDecoration: 'line-through', color: 'grey' }}
        >
          {product.originalPrice.toLocaleString('vi-VN')} VND
        </Typography>
        <Typography variant="h6" sx={{ color: 'orange', fontWeight: 'bold' }}>
          {product.discountedPrice.toLocaleString('vi-VN')} VND
        </Typography>
        <Box sx={{ display: 'flex', marginTop: 1 }}>
          {product.icons.map((icon, index) => (
            <Box
              key={index}
              sx={{
                width: 20,
                height: 20,
                borderRadius: '50%',
                backgroundColor: icon.color,
                marginRight: 1,
              }}
            />
          ))}
        </Box>
      </CardContent>
    </Card>
  )
}

export default ProductCard
