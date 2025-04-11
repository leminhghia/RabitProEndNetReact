import React, { useState } from 'react'
import { Box, Grid, Typography, Avatar } from '@mui/material'
import './Categories.css' // Optional: For custom styles

const categories = [
  // Bé gái
  {
    id: 1,
    name: 'Đầm',
    image: 'https://via.placeholder.com/100?text=Đầm',
    gender: 'Bé gái',
  },
  {
    id: 2,
    name: 'Đồ bộ',
    image: 'https://via.placeholder.com/100?text=Đồ+bộ',
    gender: 'Bé gái',
  },
  {
    id: 3,
    name: 'Áo khoác',
    image: 'https://via.placeholder.com/100?text=Áo+khoác',
    gender: 'Bé gái',
  },
  {
    id: 4,
    name: 'Áo',
    image: 'https://via.placeholder.com/100?text=Áo',
    gender: 'Bé gái',
  },
  {
    id: 5,
    name: 'Quần',
    image: 'https://via.placeholder.com/100?text=Quần',
    gender: 'Bé gái',
  },
  {
    id: 6,
    name: 'Đồ lót',
    image: 'https://via.placeholder.com/100?text=Đồ+lót',
    gender: 'Bé gái',
  },
  {
    id: 7,
    name: 'Phụ kiện',
    image: 'https://via.placeholder.com/100?text=Phụ+kiện',
    gender: 'Bé gái',
  },
  {
    id: 8,
    name: 'Easy Wear',
    image: 'https://via.placeholder.com/100?text=Easy+Wear',
    gender: 'Bé gái',
  },

  // Bé trai
  {
    id: 9,
    name: 'Áo',
    image: 'https://via.placeholder.com/100?text=Áo',
    gender: 'Bé trai',
  },
  {
    id: 10,
    name: 'Quần',
    image: 'https://via.placeholder.com/100?text=Quần',
    gender: 'Bé trai',
  },
  {
    id: 11,
    name: 'Đồ bộ',
    image: 'https://via.placeholder.com/100?text=Đồ+bộ',
    gender: 'Bé trai',
  },
  {
    id: 12,
    name: 'Áo khoác',
    image: 'https://via.placeholder.com/100?text=Áo+khoác',
    gender: 'Bé trai',
  },
  {
    id: 13,
    name: 'Áo sơ mi',
    image: 'https://via.placeholder.com/100?text=Áo+sơ+mi',
    gender: 'Bé trai',
  },
  {
    id: 14,
    name: 'Marvel',
    image: 'https://via.placeholder.com/100?text=Marvel',
    gender: 'Bé trai',
  },
  {
    id: 15,
    name: 'Đồ lót',
    image: 'https://via.placeholder.com/100?text=Đồ+lót',
    gender: 'Bé trai',
  },
  {
    id: 16,
    name: 'Phụ kiện',
    image: 'https://via.placeholder.com/100?text=Phụ+kiện',
    gender: 'Bé trai',
  },
  {
    id: 17,
    name: 'Easy Wear',
    image: 'https://via.placeholder.com/100?text=Easy+Wear',
    gender: 'Bé trai',
  },
]

const Categories = () => {
  const [selectedGender, setSelectedGender] = useState('Bé gái') // Mặc định là 'Bé gái'

  // Lọc danh sách categories dựa trên giới tính được chọn
  const filteredCategories = selectedGender
    ? categories.filter((category) => category.gender === selectedGender)
    : categories

  return (
    <Box sx={{ padding: '20px', textAlign: 'center' }}>
      {/* Gender Headers */}
      <Box
        sx={{ display: 'flex', justifyContent: 'center', marginBottom: '20px' }}
      >
        <Typography
          variant="h6"
          sx={{
            margin: '0 20px',
            color: selectedGender === 'Bé gái' ? '#f28c38' : '#666',
            cursor: 'pointer',
            '&:hover': { color: '#f28c38' },
          }}
          onClick={() => setSelectedGender('Bé gái')}
        >
          Bé gái
        </Typography>
        <Typography
          variant="h6"
          sx={{
            margin: '0 20px',
            color: selectedGender === 'Bé trai' ? '#f28c38' : '#666',
            cursor: 'pointer',
            '&:hover': { color: '#f28c38' },
          }}
          onClick={() => setSelectedGender('Bé trai')}
        >
          Bé trai
        </Typography>
      </Box>

      {/* Categories Grid */}
      <Grid container spacing={2} justifyContent="center">
        {filteredCategories.map((category) => (
          <Grid item key={category.id} xs={6} sm={3} md={2}>
            <Box
              sx={{
                display: 'flex',
                flexDirection: 'column',
                alignItems: 'center',
              }}
            >
              <Avatar
                src={category.image}
                alt={category.name}
                sx={{
                  width: 100,
                  height: 100,
                  borderRadius: '50%',
                  backgroundColor: '#ffebee',
                }}
              />
              <Typography
                variant="body2"
                sx={{ marginTop: '10px', color: '#333' }}
              >
                {category.name}
              </Typography>
            </Box>
          </Grid>
        ))}
      </Grid>
    </Box>
  )
}

export default Categories
