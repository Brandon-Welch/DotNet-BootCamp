// Functions in TS are similiar to JS
//we have the ability now though to have typed paramanetrs and return types

//regular funciton
//function reference(param: type): returnType{}
function addNumbers(x: number, y: number): number{
    return x + y;
}

let sum: number = addNumbers(3, 5);
console.log(sum); //output = 8

//Arrow syntax
//Arrow functins provide a more concise syntax lexically (keeps it within the definition of the function itself) bind this value
const multipleNumbers = (x: number, y: number): number => {
    return x * y;
}

//Anonymous Functions
//These are functions without a name, often used as arguments to other functions
//You can pass a function, as a paramanet
setTimeout(function(){
    console.log("This is an anonomyous function")
}, 1000);

setTimeout(() => {
    console.log("This is an arrow anonymous function")
}, 1000);

//Function Overloading
//TS supports function overladig, allowing multiple function signatures for a single function body
function concatenate(x: string, y: string): string;
function concatenate(x: number, y: number): number;
function concatenate(x: any, y: any): any{
    return x + y;
}

let stringResult = concatenate("hello ", "world"); //output = hello world
let numberResult = concatenate(5, 10); // output = 15


//Optional and Default parameters
    //Optional Parameters
    //these are specified with a ?

function greetPerson(name: string, greeting?: string){
    if (greeting){
        return `${greeting}, ${name}`;
    }
    else{
        return `Hello there, ${name}`;
    }
}

    //Default Parameters
    //these provide a way to provide a default value if nothing is given

function greetDetault(name: string, greeting: string = "Hello"): string{
    return `${greeting}, ${name}`;
}


//Rest parameters
//this allows a function to accept an indefinte number of arguments as an arry
//rest parameter, must be the last parament
function summing(greeting: string, ...numbers: number[]): string {
    let total = numbers.reduce((total, num) => total + num, 0);
    return `${greeting}, your total is: ${total}.`
}

console.log(summing('Mike', 3, 4, 5, 6, 7, 8, 10));