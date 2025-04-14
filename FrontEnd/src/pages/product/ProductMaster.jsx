import { Box, Container, Grid } from '@mui/material'
import FilterSidebar from '../../Component/product/FilterSidebar'
import ProductCard from '../../Component/product/ProductCard'

const mockProducts = [
  {
    name: '[Độc quyền Online] Áo thun ngắn tay',
    image: 'https://via.placeholder.com/200x200',
    discountedPrice: '125,300',
    originalPrice: '179,000',
    isNew: false,
  },
  {
    name: '[Độc quyền Online] Đầm váy bé gái',
    image: 'https://via.placeholder.com/200x200',
    discountedPrice: '194,350',
    originalPrice: '299,000',
    isNew: true,
  },
  {
    name: '[Độc quyền Online] Đầm váy bé gái',
    image: 'https://via.placeholder.com/200x200',
    discountedPrice: '194,350',
    originalPrice: '299,000',
    isNew: true,
  },
  {
    name: '[Độc quyền Online] Đầm váy bé gái',
    image: 'https://via.placeholder.com/200x200',
    discountedPrice: '194,350',
    originalPrice: '299,000',
    isNew: true,
  },
  {
    name: '[Độc quyền Online] Đầm váy bé gái',
    image: 'https://via.placeholder.com/200x200',
    discountedPrice: '194,350',
    originalPrice: '299,000',
    isNew: true,
  },
  // Add more products...
]

const ProductPage = () => {
  return (
    <Container>
      <Box display="flex">
        <FilterSidebar />
        <Box flexGrow={1} p={2}>
          <Grid container spacing={2}>
            {mockProducts.map((product, index) => (
              <Grid item xs={12} sm={6} lg={3} key={index}>
                <ProductCard product={product} />
              </Grid>
            ))}
          </Grid>
        </Box>
      </Box>
    </Container>
  )
}

export default ProductPage
