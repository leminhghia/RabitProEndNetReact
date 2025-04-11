import { Box, Typography } from '@mui/material'
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
const BannerHome = () => {
  return (
    <Box
      sx={{
        width: '100%', // thay 100vw bằng 100%
        position: 'relative',
        // Có thể bỏ left và transform nếu không cần thiết để căn giữa
        height: 600,
        overflow: 'hidden',
        boxSizing: 'border-box',
      }}
    >
      <Box
        sx={{
          display: 'flex',
          transition: 'transform 1s ease',
          width: '300%', // 3 slides
          animation: 'slide 15s infinite',
        }}
      >
        <StyledBanner sx={{ minWidth: '100%' }}>
          <Typography variant="h3" component="h1">
            Banner Quảng Cáo 1
          </Typography>
        </StyledBanner>
        <StyledBanner sx={{ minWidth: '100%' }}>
          <Typography variant="h3" component="h1">
            Banner Quảng Cáo 2
          </Typography>
        </StyledBanner>
        <StyledBanner sx={{ minWidth: '100%' }}>
          <Typography variant="h3" component="h1">
            Banner Quảng Cáo 3
          </Typography>
        </StyledBanner>
      </Box>
      <Box
        sx={{
          position: 'absolute',
          top: '50%',
          left: '20px',
          transform: 'translateY(-50%)',
          zIndex: 1,
          backgroundColor: 'rgba(255, 255, 255, 0.5)',
          borderRadius: '50%',
          width: 40,
          height: 40,
          display: 'flex',
          alignItems: 'center',
          justifyContent: 'center',
          cursor: 'pointer',
          '&:hover': {
            backgroundColor: 'rgba(255, 255, 255, 0.8)',
          },
        }}
      >
        &#10094;
      </Box>
      <Box
        sx={{
          position: 'absolute',
          top: '50%',
          right: '20px',
          transform: 'translateY(-50%)',
          zIndex: 1,
          backgroundColor: 'rgba(255, 255, 255, 0.5)',
          borderRadius: '50%',
          width: 40,
          height: 40,
          display: 'flex',
          alignItems: 'center',
          justifyContent: 'center',
          cursor: 'pointer',
          '&:hover': {
            backgroundColor: 'rgba(255, 255, 255, 0.8)',
          },
        }}
      >
        &#10095;
      </Box>
      <style>
        {`
				@keyframes slide {
					0%, 30% { transform: translateX(0); }
					33%, 63% { transform: translateX(-33.33%); }
					66%, 96% { transform: translateX(-66.66%); }
					100% { transform: translateX(0); }
				}
			`}
      </style>
    </Box>
  )
}

export default BannerHome
