import React from 'react'
import {
  Grid,
  Card,
  CardContent,
  CardMedia,
  Typography,
  Button,
  Box,
} from '@mui/material'
import CalendarTodayIcon from '@mui/icons-material/CalendarToday'

function Blog() {
  // Dữ liệu mẫu cho các bài viết
  const articles = [
    {
      title: 'Bật Mí Tuyệt Chiêu Phối Đồ Cho Bé Phong Cách Hàn Quốc Cực Đẹp',
      date: 'Th 2 31/03/2025',
      description:
        'Khi nói đến thời trang cho bé, phong cách Hàn Quốc luôn đứng top trong lòng mẹ vì vẻ nhẹ nhàng, tinh tế và dễ thương…',
      image: 'https://via.placeholder.com/150',
    },
    {
      title: 'Cách Giặt Và Bảo Quản Quần Áo Trẻ Em An Toàn, Bền Lâu Như Mới',
      date: 'Th 2 29/03/2025',
      description:
        'Để bảo vệ con luôn khỏe mạnh, ba mẹ cần chú ý đến cách giặt và hướng dẫn bảo quản quần áo trẻ em đúng cách…',
      image: 'https://via.placeholder.com/150',
    },
    {
      title:
        'Chất Liệu Vải Modal Là Gì? Tại Sao Vải Modal Tốt Hơn Cả Vải Cotton?',
      date: 'Th 2 27/03/2025',
      description:
        'Vải Modal với nhiều ưu điểm vượt trội đã làm cho nó trở thành lựa chọn ngày càng phổ biến…',
      image: 'https://via.placeholder.com/150',
    },
    {
      title:
        'Top 10 Set Đồ Bộ Trẻ Em Mặc Nhà Thoáng Mát, Thấm Hút Mồ Hôi Tốt Mọi Tủi Ban Chạy Nhất',
      date: 'Th 2 25/03/2025',
      description:
        'Trong những ngày hè nóng bức, việc lựa chọn đồ bộ trẻ em cần đặc biệt chú ý đến chất liệu và thiết kế…',
      image: 'https://via.placeholder.com/150',
    },
  ]

  return (
    <Box sx={{ padding: 4 }}>
      <Grid
        container
        spacing={4}
        sx={{
          display: 'flex',
          alignItems: 'stretch', // Đảm bảo cả hai phần kéo dài để có chiều cao bằng nhau
          minHeight: '600px', // Đặt chiều cao tối thiểu để đảm bảo không gian đủ lớn
        }}
      >
        {/* Phần Bên Trái: Banner */}
        <Grid item xs={12} md={6}>
          <Card
            sx={{
              position: 'relative',
              backgroundColor: '#FFC107',
              height: '100%', // Đảm bảo card chiếm toàn bộ chiều cao của phần cha
              display: 'flex',
              flexDirection: 'column',
            }}
          >
            <CardMedia
              component="img"
              image="https://via.placeholder.com/600x400" // Thay bằng hình ảnh banner thực tế
              alt="Banner"
              sx={{
                height: '100%', // Đảm bảo hình ảnh chiếm toàn bộ chiều cao của card
                objectFit: 'cover', // Đảm bảo hình ảnh được mở rộng để lấp đầy không gian
              }}
            />
            <Box
              sx={{
                position: 'absolute',
                top: 20,
                left: 20,
                color: 'black',
              }}
            >
              <Typography variant="h4" sx={{ fontWeight: 'bold' }}>
                Áo Thun Trẻ Em In Hình Việt Nam
              </Typography>
              <Typography variant="h6" sx={{ marginTop: 1 }}>
                Lựa chọn ý nghĩa cho bé dịp 30/4
              </Typography>
              <Box sx={{ display: 'flex', alignItems: 'center', marginTop: 2 }}>
                <CalendarTodayIcon sx={{ marginRight: 1 }} />
                <Typography variant="body2">Th 3 08/04/2025</Typography>
              </Box>
              <Button variant="contained" color="primary" sx={{ marginTop: 2 }}>
                Đọc tiếp
              </Button>
            </Box>
          </Card>
        </Grid>

        {/* Phần Bên Phải: Danh Sách Bài Viết */}
        <Grid item xs={12} md={6}>
          <Box
            sx={{
              height: '100%', // Đảm bảo container chiếm toàn bộ chiều cao
              display: 'flex',
              flexDirection: 'column',
              gap: 2, // Khoảng cách giữa các card
              overflowY: 'auto', // Cho phép cuộn nếu nội dung vượt quá chiều cao
            }}
          >
            {articles.map((article, index) => (
              <Card
                key={index}
                sx={{
                  display: 'flex',
                  minHeight: '150px', // Đảm bảo chiều cao tối thiểu cho mỗi card
                }}
              >
                <CardMedia
                  component="img"
                  sx={{ width: 150 }}
                  image={article.image}
                  alt={article.title}
                />
                <CardContent>
                  <Typography variant="h6" sx={{ fontWeight: 'bold' }}>
                    {article.title}
                  </Typography>
                  <Box
                    sx={{ display: 'flex', alignItems: 'center', marginTop: 1 }}
                  >
                    <CalendarTodayIcon
                      sx={{ marginRight: 1, fontSize: 'small' }}
                    />
                    <Typography variant="body2">{article.date}</Typography>
                  </Box>
                  <Typography variant="body2" sx={{ marginTop: 1 }}>
                    {article.description}
                  </Typography>
                </CardContent>
              </Card>
            ))}
          </Box>
        </Grid>
      </Grid>
    </Box>
  )
}

export default Blog
