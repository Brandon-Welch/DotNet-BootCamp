import React, { useState } from 'react'
 
function Greeting() {
    const [changedText, setChangedText] = useState(false);
   
    function changeTextHandler(){
        setChangedText(true);
        //setChangedText(!setChangedText); //added test
    }
 
  return (
    <div>
        <h4>Hello World</h4>
        {!changedText && <p>It's nice to meet you</p>}
        {changedText && <p>I have been changed</p>}
        <button onClick={changeTextHandler}>Change Text!</button>
    </div>
  )
}
 
export default Greeting