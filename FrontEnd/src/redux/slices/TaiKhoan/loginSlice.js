import { createAsyncThunk, createSlice } from '@reduxjs/toolkit'

// Define API URL from environment or constants
const API_URL = 'https://localhost:5001/api'

// Initial state
const initialState = {
  user: null,
  token: null,
  isLoading: false,
  error: null,
  userList: [],
}

// Fetch user list thunk
export const fetchUserList = createAsyncThunk(
  'user-info/fetchUserList',
  async (_, thunkAPI) => {
    try {
      const response = await fetch(`${API_URL}/taikhoan/user-info`)
      if (!response.ok) {
        throw new Error('Failed to fetch user list')
      }
      const data = await response.json()
      return data
    } catch (error) {
      return thunkAPI.rejectWithValue(error.message || 'An error occurred')
    }
  }
)

// Login thunk
export const loginUser = createAsyncThunk(
  'login/loginUser',
  async (credentials, thunkAPI) => {
    try {
      const response = await fetch(`${API_URL}/login`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(credentials),
      })
      if (!response.ok) {
        const errorData = await response.json()
        throw new Error(errorData.message || 'Login failed')
      }
      const data = await response.json()
      // Store token in localStorage for persistence
      localStorage.setItem('token', data.token)
      return data
    } catch (error) {
      return thunkAPI.rejectWithValue(error.message || 'Login failed')
    }
  }
)
// Register thunk
export const registerUser = createAsyncThunk(
  'register/registerUser',
  async ({ email, password }, thunkAPI) => {
    try {
      const response = await fetch(`${API_URL}/account/register`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({ email, password }),
      })

      const text = await response.text()
      const data = text ? JSON.parse(text) : {}

      if (!response.ok) {
        throw new Error(data.message || 'Registration failed')
      }

      return data
    } catch (error) {
      return thunkAPI.rejectWithValue(error.message || 'Registration failed')
    }
  }
)

// Create the slice
export const loginSlice = createSlice({
  name: 'login',
  initialState,
  reducers: {
    logout: (state) => {
      state.user = null
      state.token = null
      state.error = null
      localStorage.removeItem('token')
    },
    clearError: (state) => {
      state.error = null
    },
  },

  extraReducers: (builder) => {
    // Handle login cases
    builder
      .addCase(loginUser.pending, (state) => {
        state.isLoading = true
        state.error = null
      })
      .addCase(loginUser.fulfilled, (state, action) => {
        state.isLoading = false
        state.user = action.payload.user
        state.token = action.payload.token
        state.error = null
      })
      .addCase(loginUser.rejected, (state, action) => {
        state.isLoading = false
        state.error = action.payload || 'Login failed'
      })
      // Handle fetch user list cases
      .addCase(fetchUserList.pending, (state) => {
        state.isLoading = true
        state.error = null
      })
      .addCase(fetchUserList.fulfilled, (state, action) => {
        state.isLoading = false
        state.userList = action.payload
        state.error = null
      })
      .addCase(fetchUserList.rejected, (state, action) => {
        state.isLoading = false
        state.error = action.payload || 'Failed to fetch user list'
      })
      // Handle register user cases
      .addCase(registerUser.pending, (state) => {
        state.isLoading = true
        state.error = null
      })
      .addCase(registerUser.fulfilled, (state, action) => {
        state.isLoading = false
        // Optional: set user/token if you log them in immediately after registration
        state.user = action.payload.user || null
        state.token = action.payload.token || null
        state.error = null
      })
      .addCase(registerUser.rejected, (state, action) => {
        state.isLoading = false
        state.error = action.payload || 'Registration failed'
      })
  },
})

// Export actions
export const { logout, clearError } = loginSlice.actions

// Export reducer
export default loginSlice.reducer
