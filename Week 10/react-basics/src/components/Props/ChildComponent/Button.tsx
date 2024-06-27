import React from 'react'

function Button(props: {bgColor: string, isRound?: boolean, randomThing?: number}) { //? makes that requirement optional
    console.log(props)
    return (
        
      <button style={{
          backgroundColor: props.bgColor,
          color: "white",
          border: "none",
          borderRadius: props.isRound ? "20px" : "0px",
          padding: "8px",
          fontSize: "20px"
      }}>Click Me</button>
    )
  }

export default Button