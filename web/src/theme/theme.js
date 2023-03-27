import { defineStyleConfig, extendTheme } from '@chakra-ui/react';
import { CardBodyComponent } from './additions/card/CardBody';
import { CardHeaderComponent } from './additions/card/CardHeader';
import { CardComponent, CCardComponent } from './additions/card/CCard';
import { buttonStyles } from './components/button';
import { linkStyles } from './components/link';
import { breakpoints } from './foundations/breakpoints';
import { globalStyles } from './styles';
// import { mode } from "@chakra-ui/theme-tools";

const config = {
  initialColorMode: 'light',
  useSystemColorMode: false,
}

const HeadingStyle = defineStyleConfig({
  baseStyle: {
    fontFamily: "'Roboto', sans-serif"
  }
});

 const HeadingComponent = {
  components: {
    Heading: HeadingStyle
  }
};

export default extendTheme(
	{ breakpoints }, // Breakpoints
	globalStyles,
	buttonStyles, // Button styles
	linkStyles, // Link styles
	CCardComponent, // Card component
	CardBodyComponent, // Card Body component
	CardHeaderComponent, // Card Header component
	CardComponent,
	{ config },
	HeadingComponent
	
);
