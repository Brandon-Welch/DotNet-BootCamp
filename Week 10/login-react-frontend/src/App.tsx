import React, { useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import LoginComponent, { User } from './Components/LoginComponent/LoginComponent';
import UserProfileComponent from './Components/UserProfileComponent/UserProfileComponent';
import { UserContext } from './context/UserContext';
import NavBar from './Components/NavBar/NavBar';
import ProfileComponent from './Components/ProfileComponent/ProfileComponent';
import ForgotPassword from './Components/ForgotPassword/ForgotPassword';
import PasswordReset from './Components/PasswordReset/PasswordReset';

function App() {
  /*
    By using UserContext.Provider, anything inside of it can reference the user with useContext anywhere without having to provide it with props

  */
  const [user, setUser] = useState<User | undefined>(undefined);
  
  return ( 
    <div className="App">
      {/* <UserContext.Provider value={user}> */}
        {/* <UserProfileComponent/> */}
        <NavBar/>
        <Routes>
          <Route path="/" element={<LoginComponent setUser={setUser}/>}/>
          <Route path="/profile" element={<ProfileComponent/>}></Route>
          <Route path="/forgotpassword" element={<ForgotPassword/>}></Route>
          <Route path="/resetpassword" element={<PasswordReset/>}></Route>
        </Routes>
      {/* </UserContext.Provider> */}
    </div>
  );
}

export default App;
