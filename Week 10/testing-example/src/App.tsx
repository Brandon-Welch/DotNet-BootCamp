import React from 'react';
import logo from './logo.svg';
import './App.css';
import Counter from './Components/Counter/Counter';
import Greeting from './Components/Greeting/Greeting';
import Async from './Components/Async/Async';

function App() {
  return (
    <div className="App">
      <h1>Testing Examples</h1>
      <p>____________________________________________________________________________________________________________________________</p>
      <p>____________________________________________________________________________________________________________________________</p>
      <h3><u>Counter Component</u></h3>
      <Counter/>
      <p>_____________________________________________________________________</p>
      <h3><u>Greeting Component</u></h3>
      <Greeting/>
      <p>_____________________________________________________________________</p>
      <h3><u>Async Component</u></h3>
      <Async/>
      <p>_____________________________________________________________________</p>
    </div>
  );
}

export default App;
