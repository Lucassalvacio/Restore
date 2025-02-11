import { AppBar, IconButton, Toolbar, Typography } from "@mui/material";
import { DarkMode, LightMode } from "@mui/icons-material";

type Props = {
  darkMode: React.Dispatch<React.SetStateAction<boolean>>;
  dark: boolean;
};

const Navbar = ({ darkMode, dark }: Props) => {
  const switchMode = () => {
    darkMode((currMode) => !currMode);
  };

  return (
    <AppBar position="fixed">
      <Toolbar sx={{ display: "flex", justifyContent: "space-between" }}>
        <Typography variant="h6">RE-STORE</Typography>
        <IconButton onClick={switchMode}>
          {dark == false ? <LightMode sx={{color: 'yellow'}}/> : <DarkMode color="action"/>}
        </IconButton>
      </Toolbar>
    </AppBar>
  );
};
export default Navbar;
