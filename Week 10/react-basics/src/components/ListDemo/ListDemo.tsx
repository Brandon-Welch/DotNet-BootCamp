import React from 'react'
import "./ListDemo.css";

function ListDemo() {

    let people = [
        {
            firstName: "John",
            lastName: "Doe"
        },
        {
            firstName: "Jane",
            lastName: "Doe"
        },
        {
            firstName: "Mick",
            lastName: "Doe"
        },
    ]

  return (
    //<div className='ListDemo'>ListDemo</div>
    <>
        <p className='ListDemo'>List Demo</p>
        {
            /*
                To display each item in an arry to the DOM, we use the map function
                The Map function transforms each item in an array in a specific way that you can define
            */

           people.map((obj, index) => {
                return (
                    <div className='ListDemo' key={index}>
                        <h3>{obj.firstName}</h3>
                        {obj.lastName}
                        <br></br>
                        <br></br>
                        {obj.firstName} {obj.lastName}
                    </div>
                );
           })
        }
    </>
  )
}

export default ListDemo