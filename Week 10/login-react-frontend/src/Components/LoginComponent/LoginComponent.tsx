import React, { useEffect, useState } from "react";
import LoginFormComponent from "./LoginFormComponent/LoginFormComponent";

//Base URL
const BASE_URL = "http://localhost:5074";
let setUser = {};

export interface UserLoginInput {
  userName: string;
  userPassword: string;
}

// This interface is based on your backend API
// If you are returning fields that are essential to your application, make sure to include it here
// Make sure the fields match the response JSON
export interface User {
  userId: number;
  userName: string;
  firstName: string;
  lastName: string;
  email: string;
  isManager: boolean;
  isAdmin: boolean;
}

function LoginComponent(props: any) {
  /*
        We are going to set the logged in user as the state variable
        This is because, this variable is critical to the rendering of the application

    */
  // const [user, setUser] = useState<User | undefined>(undefined);

  /*
        Because we want to do the API call inside of the parent component, we need to pass the login input into the parent.

        The only way to do that so far is through lifting state, i.e. we will create a state variable inside the parent and then pass the function for setting the state variable into the child
    */
  const [loginInput, setLoginInput] = useState<UserLoginInput | undefined>(
    undefined
  );

  useEffect(() => {
    /*
            We are not going to communicate to an API in this example, but assume here is where you would do you fetch / axios request to your backend API to login in the user
        */

    // if (loginInput?.userName === "user1" && loginInput?.userPassword === "pass1") {
    //   console.log("logged in!");
    //   // We assume we will get back the correct user when we log in
    //   let loggedInUser: User = {
    //     userId: 1,
    //     userName: "user1",
    //     firstName: "John",
    //     lastName: "Doe",
    //     email: "john.doe@email.com",
    //     age: 33,
    //     isAdmin: false,
    //   };
    //   props.setUser(loggedInUser);
    // } else {
    //   console.log("Not logged in!");
    //   props.setUser(undefined);
    // }

    // Function to log in the user
    async function LoginUser() {
      try {
        let response = await fetch(`${BASE_URL}/Login/login`, {
          method: "POST",
          headers: {
            "Content-Type": "application/json", // Corrected the content type to 'application/json'
          },
          body: JSON.stringify({loginInput})
             });

        let data = await response.json();
        setUser = data;
        //console.log(setUser);
        console.log(data);
        console.log("Logged In!")
      } catch (error) {
        console.error("Error logging in:", error); // Added error logging
        console.log("Not logged in!");
        props.setUser(undefined);
      }
    }
  }, [loginInput]);

  return (
    <div>
      <LoginFormComponent setLoginInput={setLoginInput} />
    </div>
  );
}

export default LoginComponent;
