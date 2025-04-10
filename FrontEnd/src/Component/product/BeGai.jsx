import React, { useState } from 'react'
import {
  Grid,
  Card,
  CardMedia,
  CardContent,
  Typography,
  Button,
  Box,
  IconButton,
  Tabs,
  Tab,
} from '@mui/material'
import ShoppingCartIcon from '@mui/icons-material/ShoppingCart'
import VisibilityIcon from '@mui/icons-material/Visibility'

const products = [
  {
    id: 1,
    name: 'Đầm thun dài tay bé gái Rubiity',
    price: '290.000đ',
    image: 'https://via.placeholder.com/200x250?text=Product+1',
    colors: ['#FF0000', '#00FF00', '#0000FF'], // Red, Green, Blue
  },
  {
    id: 2,
    name: 'Đầm bé gái Rubiity 950.069',
    price: '290.000đ',
    image: 'https://via.placeholder.com/200x250?text=Product+2',
    colors: ['#FF00FF', '#FFFF00', '#00FFFF'], // Magenta, Yellow, Cyan
  },
  {
    id: 3,
    name: 'Áo thun bé gái Rubiity 901.110',
    price: '190.000đ',
    image: 'https://via.placeholder.com/200x250?text=Product+3',
    colors: ['#FF0000', '#FFFFFF', '#000000'], // Red, White, Black
  },
  {
    id: 4,
    name: 'Áo thun bé gái Rubiity 500.089',
    price: '190.000đ',
    image: 'https://via.placeholder.com/200x250?text=Product+4',
    colors: ['#FF0000', '#00FF00', '#0000FF'],
  },
  {
    id: 5,
    name: 'Áo thun bé gái Rubiity 901.105',
    price: '190.000đ',
    image: 'https://via.placeholder.com/200x250?text=Product+5',
    colors: ['#FF00FF', '#FFFF00', '#00FFFF'],
  },
  {
    id: 6,
    name: 'Đầm bé gái Rubiity 950.070',
    price: '290.000đ',
    image: 'https://via.placeholder.com/200x250?text=Product+6',
    colors: ['#FF0000', '#FFFFFF', '#000000'],
  },
  {
    id: 7,
    name: 'Đầm thun Elsa bé gái',
    price: '380.000đ',
    image: 'https://via.placeholder.com/200x250?text=Product+7',
    colors: ['#FF0000', '#00FF00', '#0000FF'],
  },
  {
    id: 8,
    name: 'Đầm bé gái Rubiity 950.075',
    price: '290.000đ',
    image: 'https://via.placeholder.com/200x250?text=Product+8',
    colors: ['#FF00FF', '#FFFF00', '#00FFFF'],
  },
]

const BeGai = () => {
  const [selectedColors, setSelectedColors] = useState({})
  const [hoveredProduct, setHoveredProduct] = useState(null)
  const [selectedTab, setSelectedTab] = useState(0)

  const handleColorSelect = (productId, color) => {
    setSelectedColors((prev) => ({
      ...prev,
      [productId]: color,
    }))
  }

  const handleTabChange = (event, newValue) => {
    setSelectedTab(newValue)
  }

  return (
    <div className="App">
      <Typography variant="h4" align="center" gutterBottom>
        THỜI TRANG BÉ GÁI
      </Typography>
      <Box
        sx={{
          borderBottom: 1,
          borderColor: 'divider',
          maxWidth: '920px',
          margin: '0 auto',
        }}
      >
        <Tabs
          value={selectedTab}
          onChange={handleTabChange}
          centered
          sx={{
            '& .MuiTab-root': {
              fontSize: '16px',
              fontWeight: 'bold',
              color: '#666',
              '&.Mui-selected': {
                color: '#FF6200',
              },
            },
            '& .MuiTabs-indicator': {
              backgroundColor: '#FF6200',
            },
          }}
        >
          <Tab label="Bán chạy nhất" />
          <Tab label="Đầm váy" />
          <Tab label="Đồ bộ" />
          <Tab label="Đồ lót" />
        </Tabs>
      </Box>
      <Box
        sx={{
          maxWidth: '920px', // 4 thẻ * 200px + 3 khoảng cách * 24px + 24px padding mỗi bên
          margin: '0 auto', // Căn giữa container grid
          padding: '0 24px', // Padding để khớp với khoảng cách
        }}
      >
        <Grid container spacing={3} style={{ padding: '20px 0' }}>
          {products.map((product) => (
            <Grid item xs={3} sm={3} md={3} lg={3} key={product.id}>
              <Card
                sx={{
                  position: 'relative',
                  width: '200px',
                  height: '400px',
                  display: 'flex',
                  flexDirection: 'column',
                  justifyContent: 'space-between',
                  margin: '0 auto',
                }}
              >
                <Box
                  sx={{ position: 'relative', flexShrink: 0 }}
                  onMouseEnter={() => setHoveredProduct(product.id)}
                  onMouseLeave={() => setHoveredProduct(null)}
                >
                  <CardMedia
                    component="img"
                    image={product.image}
                    alt={product.name}
                    sx={{
                      width: '200px',
                      height: '250px',
                      objectFit: 'cover',
                      transition: 'transform 0.3s ease-in-out',
                      transform:
                        hoveredProduct === product.id
                          ? 'scale(0.95)'
                          : 'scale(1)',
                    }}
                  />
                  {hoveredProduct === product.id && (
                    <Box
                      sx={{
                        position: 'absolute',
                        bottom: 0,
                        left: 0,
                        width: '100%',
                        backgroundColor: '#fff',
                        display: 'flex',
                        justifyContent: 'center',
                        alignItems: 'center',
                        padding: '5px 10px',
                        boxShadow: '0 -2px 5px rgba(0, 0, 0, 0.1)',
                        animation: 'slideUp 0.3s ease-in-out forwards',
                        '@keyframes slideUp': {
                          from: {
                            transform: 'translateY(100%)',
                            opacity: 0,
                          },
                          to: {
                            transform: 'translateY(0)',
                            opacity: 1,
                          },
                        },
                      }}
                    >
                      <Box display="flex" alignItems="center">
                        <IconButton
                          sx={{
                            padding: '5px',
                            animation: 'fadeIn 0.3s ease-in-out 0.2s forwards',
                            opacity: 0,
                          }}
                        >
                          <ShoppingCartIcon
                            sx={{ color: '#FF6200', fontSize: '20px' }}
                          />
                        </IconButton>
                        <IconButton
                          sx={{
                            padding: '5px',
                            animation: 'fadeIn 0.3s ease-in-out 0.3s forwards',
                            opacity: 0,
                          }}
                        >
                          <VisibilityIcon
                            sx={{ color: '#FF6200', fontSize: '20px' }}
                          />
                        </IconButton>
                      </Box>
                    </Box>
                  )}
                </Box>
                <CardContent
                  sx={{
                    flexGrow: 1,
                    display: 'flex',
                    flexDirection: 'column',
                    justifyContent: 'space-between',
                    padding: '10px',
                  }}
                >
                  <Box>
                    <Typography
                      variant="body2"
                      color="textSecondary"
                      align="center"
                      sx={{
                        whiteSpace: 'normal',
                        overflow: 'hidden',
                        textOverflow: 'ellipsis',
                        display: '-webkit-box',
                        WebkitLineClamp: 2,
                        WebkitBoxOrient: 'vertical',
                        minHeight: '40px',
                      }}
                    >
                      {product.name}
                    </Typography>
                    <Typography
                      variant="h6"
                      component="p"
                      align="center"
                      sx={{ marginTop: '5px', minHeight: '30px' }}
                    >
                      {product.price}
                    </Typography>
                  </Box>
                  <Box display="flex" justifyContent="center" mt={1} mb={1}>
                    {product.colors.map((color) => (
                      <Button
                        key={color}
                        onClick={() => handleColorSelect(product.id, color)}
                        sx={{
                          width: 30,
                          height: 30,
                          minWidth: 0,
                          borderRadius: '50%',
                          backgroundColor: color,
                          border:
                            selectedColors[product.id] === color
                              ? '2px solid #000'
                              : '1px solid #ccc',
                          mx: 1,
                          '&:hover': {
                            backgroundColor: color,
                            opacity: 0.8,
                          },
                        }}
                      />
                    ))}
                  </Box>
                </CardContent>
              </Card>
            </Grid>
          ))}
        </Grid>
        <Box sx={{ display: 'flex', justifyContent: 'center', mt: 2 }}>
          <Button
            variant="contained"
            sx={{
              backgroundColor: '#FF6200',
              '&:hover': { backgroundColor: '#cc4e00' },
            }}
          >
            Xem Thêm
          </Button>
        </Box>
      </Box>
    </div>
  )
}

export default BeGai
