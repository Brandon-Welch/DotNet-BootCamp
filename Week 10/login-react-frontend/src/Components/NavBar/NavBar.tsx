import React from 'react'
import { Link } from 'react-router-dom';
import logo from "../../Images/logo2.png";
import "./Nav.css";

 
function NavBar() {
  const [useState] = React.useState(false);
  return (
  <>
  <div id="header">
    <Link id="login-link" to={useState ? "/WelcomeLoggedInUser" : "/"}>
      <img src={logo} alt="Logo" id="header-logo" />
    </Link>

    <div id="nav-container">
      <ul id="nav">
        <li className="dropdown">
          {" "}
          Profile{" "}
          <ul className="dropdown-content">
            <li>
              {" "}
              <Link to="/">
                {" "}
                 Login{" "}
              </Link>
            </li>

            <li>
            {/* Should we make this a button on login? */}
              <Link to="resetpassword"> 
                Reset
                Password
              </Link>
            </li>

            <li>
              <Link to="/">
                {" "}
                Logout
              </Link>
            </li>
          </ul>
        </li>

        
        <li className="dropdown">
          {" "}
          Leave{" "}
          <ul className="dropdown-content">
            <li>
              <Link to="leave">
               {" "}
                Leave Requests{" "}
              </Link>{" "}
            </li>
          </ul>
        </li>

        <li className="dropdown">
          {" "}
          Performance{" "}
          <ul className="dropdown-content">
            <li>
              <Link to="Goals">
                 Goals{" "}
              </Link>{" "}
            </li>
          </ul>
        </li>

        <li className="dropdown">
          {" "}
          Administrative{" "}
          <ul className="dropdown-content">
            <li>
              <Link to="Admin">
                 Admin
                Page{" "}
              </Link>{" "}
            </li>
            <li>
              <Link to="Reporting">
             {" "}
                Reporting{" "}
              </Link>{" "}
            </li>
          </ul>
        </li>

      </ul>
    </div>
  </div>
</>
  );
}
 
export default NavBar;
 

    {/*
    <nav className="navbar navbar-expand-lg bg-body-tertiary">
      <div className="container-fluid">
      <Link className="navbar-brand" to="/"></Link>
        <div className="collapse navbar-collapse" id="navbarNavAltMarkup">
          <div className="navbar-nav">
            <a className="navbar-brand" href="#">
              <img src={logo} alt="Logo" id="header-logo" width="30" height="24"/>
            </a>
            <Link className="nav-link" to="/">
              Performance
            </Link>
            <Link className="nav-link" to="/events">
              Leave
            </Link>
            <Link className="nav-link" to="/lists">
              Admin
            </Link>
            <Link className="nav-link" to="/props">
              Profile
            </Link>
          </div>
        </div>
      </div>
    </nav>
  */}