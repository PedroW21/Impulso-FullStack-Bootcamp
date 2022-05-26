import React from 'react';
import { ThemeContext, themes } from './Theme';
import Card from './Card';

function App() {
       return (
           <ThemeContext.Provider values={themes.primary}>App
           <Card />
           </ThemeContext.Provider>
       )
}

export default App;