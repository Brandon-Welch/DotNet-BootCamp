import React from 'react'
import Button from '../ChildComponent/Button'

function ParentComponent() {
  return (
    <>
        <p>Props Demo</p>
        <Button bgColor="red" isRound={false}/>
        <span> </span>
        <Button bgColor="lightblue" isRound={true}/>
        

    </>
  )
}

export default ParentComponent