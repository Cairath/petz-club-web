import { extendTheme } from '@chakra-ui/react';
import { globalStyles } from './styles';
import { breakpoints } from './foundations/breakpoints';
import { buttonStyles } from './components/button';
import { badgeStyles } from './components/badge';
import { linkStyles } from './components/link';
import { drawerStyles } from './components/drawer';
import { CCardComponent } from './additions/card/CCard';
import { CardBodyComponent } from './additions/card/CardBody';
import { CardHeaderComponent } from './additions/card/CardHeader';
// import { mode } from "@chakra-ui/theme-tools";

const config = {
  initialColorMode: 'light',
  useSystemColorMode: false,
}

export default extendTheme(
	{ breakpoints }, // Breakpoints
	globalStyles,
	buttonStyles, // Button styles
	badgeStyles, // Badge styles
	linkStyles, // Link styles
	drawerStyles, // Sidebar variant for Chakra's drawer
	CCardComponent, // Card component
	CardBodyComponent, // Card Body component
	CardHeaderComponent, // Card Header component
	{ config }
);
