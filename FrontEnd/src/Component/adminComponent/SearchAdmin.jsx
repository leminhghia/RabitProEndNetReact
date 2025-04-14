import React from 'react'
import SearchIcon from '@mui/icons-material/Search'
const SearchAdmin = () => {
  return (
    <div className="searchAdmin position-relative d-flex align-items-center">
      <SearchIcon className="me-2" />
      <input type="text" placeholder="Search here..." />
    </div>
  )
}

export default SearchAdmin
