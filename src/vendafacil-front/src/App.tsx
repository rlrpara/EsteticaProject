import React from 'react';

import GlobalStyle from './Styles/GlobalStyles';
import Layout from "./Components/Layout";

const App: React.FC = () => {
  return (
    <>
      <GlobalStyle />
      <Layout />
    </>
  );
}

export default App;