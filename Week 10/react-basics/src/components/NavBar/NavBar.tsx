import React from 'react'
import { Link } from 'react-router-dom';

 
function NavBar() {
  return (
    <nav className="navbar navbar-expand-lg bg-body-tertiary">
      <div className="container-fluid">
      <Link className="navbar-brand" to="/">React/Bootstrap Example</Link>
        <div className="collapse navbar-collapse" id="navbarNavAltMarkup">
          <div className="navbar-nav">
            <Link className="nav-link" to="/">
              Home
            </Link>
            <Link className="nav-link" to="/events">
              Events
            </Link>
            <Link className="nav-link" to="/lists">
              Lists
            </Link>
            <Link className="nav-link" to="/props">
              Props
            </Link>
            <Link className="nav-link" to="/hooks">
              Hooks
            </Link>
            <Link className="nav-link" to="/refs">
              Refs
            </Link>
          </div>
        </div>
      </div>
    </nav>
  );
}
 
export default NavBar;
 