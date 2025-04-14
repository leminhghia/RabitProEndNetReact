import {
  Card,
  CardMedia,
  CardContent,
  Typography,
  Box,
  Chip,
  Stack,
} from '@mui/material'

const ProductCard = ({ product }) => {
  return (
    <Card sx={{ position: 'relative', maxWidth: 220, borderRadius: 3 }}>
      {product.isNew && (
        <Chip
          label="Mới"
          color="warning"
          size="small"
          sx={{ position: 'absolute', top: 8, left: 8 }}
        />
      )}
      <CardMedia
        component="img"
        height="180"
        image={product.image}
        alt={product.name}
      />
      <CardContent>
        <Typography fontSize={13} gutterBottom>
          {product.name}
        </Typography>
        <Stack direction="row" alignItems="center" spacing={1}>
          <Typography fontWeight="bold" color="error">
            {product.discountedPrice}đ
          </Typography>
          <Typography
            fontSize={12}
            sx={{ textDecoration: 'line-through', color: 'gray' }}
          >
            {product.originalPrice}đ
          </Typography>
        </Stack>
      </CardContent>
    </Card>
  )
}

export default ProductCard
