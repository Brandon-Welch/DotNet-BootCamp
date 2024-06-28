import React, { useState } from 'react'
import { User, UserLoginInput } from '../LoginComponent';
import "./LoginFormComponent.css";

function LoginFormComponent(props: any) {
    /*
        Since we are expecting to get the user input for the login, we need to store the input somewhere.

        We could use a state variable, however, this would mean that whenever that variable changes it will trigger a re-render for the component.

        This is unecessary to the functioning of the component, and so instead, we use a object with an interface type of UserLoginInput that defines the shape to have a username and password field.
    */
    // const userInput : UserLoginInput = {username: "", password: ""};
    const [userInput, setUserInput] = useState<UserLoginInput>({username: "", password: ""});
    /*
        In order to get the input from the text boxes, we need to attach event handlers to the elements. This is done by attaching a function to the events on the elements themselves.

        Text input handlers need the event object as a parameter, in order to get the value from the input box.
        You do not need to add event to the click handler (you can do if you want) as we do not need the value of the click event.
    */
    function usernameInputChangeHandler(event: any){
        // console.log(event.target.value);
        // userInput.username = event.target.value;
        setUserInput({...userInput, username: event.target.value});
    }

    function passwordInputChangeHandler(event: any){
        // console.log(event.target.value);
        // userInput.password = event.target.value;
        setUserInput({...userInput, password: event.target.value});
    }

    function submitClickHandler(){
        // console.log("Submit button clicked");
        console.log(userInput);
        props.setLoginInput(userInput);
    }

    function myModal(){
        <div className="modal"  role="dialog">
  <div className="modal-dialog" role="document">
    <div className="modal-content">
      <div className="modal-header">
        <h5 className="modal-title">Modal title</h5>
        <button type="button" className="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div className="modal-body">
        <p>Modal body text goes here.</p>
      </div>
      <div className="modal-footer">
        <button type="button" className="btn btn-primary">Save changes</button>
        <button type="button" className="btn btn-secondary" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>
    }

  return (
    <div className='LoginForm'>
        <h3>.Net Workforce User Login:</h3>
        <input className='username' onChange={usernameInputChangeHandler} type="text" placeholder='username'></input>
        <br/>
        <input className='password' onChange={passwordInputChangeHandler} type="password" placeholder='password'></input>
        <br/>
        <input className='submit_btn' onClick={submitClickHandler} type="button" value="Submit"></input>
        <input className='forgot_btn' type="button" data-toggle="modal" onClick={myModal} value="Forgot PAssword"></input>
        <p><a className='forgot_password' href="forgotpassword">Forgot Password?</a></p>
                
    </div>
  )
}

export default LoginFormComponent