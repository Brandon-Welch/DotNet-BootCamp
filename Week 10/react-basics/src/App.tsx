import React from 'react'; //similiar to c# using....
import './App.css';
import ComponentOne from './components/ComponentOne/ComponentOne';
import ComponentTwo from './components/ComponentTwo/ComponentTwo';
import EventsDemo from './components/EventsDemo/EventsDemo';
import ListDemo from './components/ListDemo/ListDemo';
import ParentComponent from './components/Props/ParentComponent/ParentComponent';
import { Route, Routes } from 'react-router-dom';
import NavBar from './components/NavBar/NavBar';
import Hooks from './components/Hooks/Hooks';
import Refs from './components/Refs/Refs';

/*
Components:
Create Folder 
> create .tsx (rfce) 
> create .css 
> import css into tsx (import "./ComponentTwo.css";)
> add compoenent into App in function (App.tsx)

add Bootstrap:
in index.html include in the /head: <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

*/


/*
class App extends React.Component{
  render(): React.ReactNode {
    return (
      <div className="App">
        <h1>Hello!</h1>
      </div>
    )
  }
}
*/


function App() : React.JSX.Element {
  //the body of the function
  // this is where you rlogic regarding the component goes
  return (
    //this return statement contains the body of the component and what will be displayed on the page

    //Whatever we return, it has to be a root element (meaning you cannot have any siblings inside the return, they must be nested inside a parent)
    <div className="App">
      {/*
      <ComponentOne/>   {/* this calls to componentone.tsx which then calls into componentone.css *}
      <ComponentTwo/>
      <EventsDemo/>
      <br></br>
      <ListDemo/>
      <br></br>
      <ParentComponent/>
      */}
      
      <NavBar/>
      <ComponentOne/> {/* if you want a component to show always, keep it in the App.tsx next to/above the Routes} */}
      <br></br>
      <Routes>
        <Route path="/" element={<ComponentTwo/>}></Route>
        <Route path="/events" element={<EventsDemo/>}></Route>
        <Route path="/lists" element={<ListDemo/>}></Route>
        <Route path="/props" element={<ParentComponent/>}></Route>
        <Route path="/hooks" element={<Hooks/>}></Route>
        <Route path="/refs" element={<Refs/>}></Route>
      </Routes>
      
    </div>
  );
}
export default App;
