import React from 'react';

import GlobalStyle from './Styles/GlobalStyles';
import Layout from "./Components/Layout";

import { ThemeProvider } from 'styled-components';

import dark from './Themes/Dark';
import light from './Themes/Ligh';

const App: React.FC = () => {
  return (
    <ThemeProvider theme={light}>
      <GlobalStyle />
      <Layout />
    </ThemeProvider>
  );
}

export default App;