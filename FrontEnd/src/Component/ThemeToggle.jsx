import { Switch } from '@mui/material'
import { useSelector, useDispatch } from 'react-redux'
import { toggleDarkMode } from '../redux/slices/themeSlice/drakMode'

const ThemeToggle = () => {
  const darkMode = useSelector((state) => state.theme.darkMode)
  const dispatch = useDispatch()

  return (
    <Switch checked={darkMode} onChange={() => dispatch(toggleDarkMode())} />
  )
}
export default ThemeToggle
