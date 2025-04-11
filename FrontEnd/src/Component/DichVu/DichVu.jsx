import React from 'react'
import { Box, Grid, Typography, Avatar } from '@mui/material'
import LocalShippingIcon from '@mui/icons-material/LocalShipping'
import RedeemIcon from '@mui/icons-material/Redeem'
import VerifiedIcon from '@mui/icons-material/Verified'
import SupportAgentIcon from '@mui/icons-material/SupportAgent'

const InfoBlock = ({ icon, title, description }) => {
  return (
    <Box display="flex" alignItems="center">
      <Avatar
        sx={{
          bgcolor: 'white',
          border: '2px solid orange',
          mr: 2,
          width: 48,
          height: 48,
        }}
      >
        {icon}
      </Avatar>
      <Box>
        <Typography variant="subtitle1" sx={{ fontWeight: 'bold' }}>
          {title}
        </Typography>
        <Typography variant="body2">{description}</Typography>
      </Box>
    </Box>
  )
}

const DichVu = () => {
  const infoData = [
    {
      icon: <LocalShippingIcon sx={{ color: 'orange' }} />,
      title: 'Miễn phí vận chuyển đơn từ 499K',
      description: 'NHẬN HÀNG TRONG 2-5 NGÀY',
    },
    {
      icon: <RedeemIcon sx={{ color: 'orange' }} />,
      title: 'Đổi/trả',
      description: 'ĐỔI TRẢ SẢN PHẨM TRONG VÒNG 30 NGÀY',
    },
    {
      icon: <VerifiedIcon sx={{ color: 'orange' }} />,
      title: 'Bảo đảm chất lượng',
      description: 'KIỂM TRA HÀNG TRƯỚC KHI NHẬN',
    },
    {
      icon: <SupportAgentIcon sx={{ color: 'orange' }} />,
      title: 'Hotline: 1900633520',
      description: 'T2 - T6 8:00-22:00',
    },
  ]

  return (
    <Box
      sx={{
        p: 4,
        display: 'flex',
        justifyContent: 'space-between',
      }}
    >
      {infoData.map((item, index) => (
        <InfoBlock
          key={index}
          icon={item.icon}
          title={item.title}
          description={item.description}
        />
      ))}
    </Box>
  )
}

export default DichVu
