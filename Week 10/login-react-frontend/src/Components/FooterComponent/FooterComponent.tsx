import React from 'react'
import { Link } from 'react-router-dom';
import logo from "../../Images/logo.png";
import "./Footer.css";
 
function Footer() {
  const [useState] = React.useState(false);
  return (
  

<div className="footer">
  <div className="footer-container">
      
    <blockquote className="blockquote mb-0">
        <br/>
      <footer>.Net Workforce | © All rights reserved</footer>
    </blockquote>
  </div>
</div>

  );
}
 
export default Footer;
 