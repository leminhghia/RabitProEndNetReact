import {
    Box,
    Container,
    CssBaseline,
  } from "@mui/material";
  import { Outlet, ScrollRestoration } from "react-router-dom";
import NavBar from "./NavBar";
  
  
  
  function App() {

  

  
    
  
  
    // const addProduct = () =>{
    //   setProducts([...products, {name:'product4',price:300.0}])
    // }
  
    return (
      <Box >
        <ScrollRestoration/>
        <CssBaseline />
        <NavBar />
   
        <Box
        
        >
          <Container maxWidth="xl" sx={{ mt: 8 }}>
           <Outlet/>
          </Container>
        </Box>
      </Box>
    );
  }
  
  export default App;
  