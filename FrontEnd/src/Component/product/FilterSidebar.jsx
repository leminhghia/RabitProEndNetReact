import {
  Box,
  Typography,
  FormGroup,
  FormControlLabel,
  Checkbox,
  Divider,
} from '@mui/material'

const FilterSidebar = () => {
  return (
    <Box sx={{ width: 250, padding: 2 }}>
      <Typography variant="h6" gutterBottom>
        Sản Phẩm Ưu Đãi
      </Typography>

      <Divider sx={{ my: 2 }} />
      <Typography variant="subtitle1">Màu Sắc</Typography>
      <FormGroup>
        {['Hồng', 'Xanh', 'Trắng', 'Tím than'].map((color) => (
          <FormControlLabel
            key={color}
            control={<Checkbox />}
            label={`GR.COR/${color}`}
          />
        ))}
      </FormGroup>

      <Divider sx={{ my: 2 }} />
      <Typography variant="subtitle1">Mức Giá</Typography>
      <FormGroup>
        {[
          'Giá dưới 100,000đ',
          '100.000đ - 200.000đ',
          '200.000đ - 300.000đ',
          '300.000đ - 400.000đ',
          'Giá trên 500.000đ',
        ].map((price) => (
          <FormControlLabel key={price} control={<Checkbox />} label={price} />
        ))}
      </FormGroup>
    </Box>
  )
}

export default FilterSidebar
