import { Box, Container, createTheme, CssBaseline, ThemeProvider } from "@mui/material";
import Catalog from "../features/catalog/Catalog";

import Navbar from "./Navbar";
import { useState } from "react";




function App() {
  const [darkMode, setDarkMode] = useState<boolean>(true);

  const paletteType = darkMode ? 'dark' : 'light'
  const theme = createTheme({
    palette: {
      mode: paletteType,
      background: {
        default: (paletteType === 'light') ? '#eaeaea' : '#121212'
      }
    }
  })


  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Navbar darkMode={setDarkMode} dark={darkMode}/>
      <Box sx={{minHeight: '100vh', background: darkMode ?  'radial-gradient(circle, #1e3aBa, #111B27)' : 'radial-gradient(circle, #baecf9, #f0f9ff)', paddingTop: '20vh'}}>
      <Container>
        <Catalog />
      </Container>  
      </Box>
      
    </ThemeProvider>
  );
}

export default App;
