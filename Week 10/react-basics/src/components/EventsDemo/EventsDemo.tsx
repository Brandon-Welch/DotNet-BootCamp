import React from 'react'
import "./EventsDemo.css";

function EventsDemo() {

    function clickEventTriggered() {
        console.log("Click button triggered!")
    }

    function hoverEventTriggered() {
        console.log("Hover event triggered!")
    }

    function inputChanged(event: any) {
        //console.log("Input has changed")
        console.log(event.target.value)
    }

  return (
    <div className='EventDemo'>
        EventDemo
        <br></br>
        <br></br>
        <button onClick={clickEventTriggered}>Click Event</button>
        <br></br>
        <br></br>
        <button onMouseOver={hoverEventTriggered}>Hover Event</button>
        <br></br>
        <br></br>
        <input type="text" placeholder="Username" onChange={inputChanged}/>
    </div>
  )
}

export default EventsDemo