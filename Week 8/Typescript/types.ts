/*
 typescript files cannot be ran by nose and must first be transpiled into JS through the typescript compiler

 npx tsc <name of file>

Common Variables

string
number
boolean
null 
undefined

the syntax for typing in typestrict is the following:

let referenceName : type = value;

in c# the syntax was:

type referenceName = value;

 */

let isDone: boolean = false;
let age: number = 26;
let firstName: string = 'John';
let u: undefined = undefined;
let n: null = null;

// Yoiu cannot reassign a valyue to somethign that does not match its declared datatype

//isDone = "Hello"; // cannot assign boolean a string
    // you can do this, and still run the transpiler to get the JS and the JS file will still work
    //however, this kind of behaviopr defeats the point of having the typescript in the first place

//Arrays
    // Syntax:
    // type[] or Array<type>
    //the typing allows us to have typesaftey in our arrays
let numberList: number[] = [1, 2, 3];
let genericNumberList: Array<number> = [1, 2, 3];


// Tuple (unique to typescripts)
// Tuples let you define an array wiht fixed types and length
let tupleExample: [string, number];
tupleExample: ["Hello", 50]; //correct
//tupleExample: [10, "Hello"]; //error


//Enums
//Enums allow you to define a set of named constants

//numerical Enum
// basically you can think of this as a predefined array where indexes are actualy values
enum Color {
    Red, //index [0]
    Green, //index [1]
    Blue=12 //assigned index [12]
}

enum StatusCodes{
    Ok = 200,
    Created = 201,
    NotFound = 404
}


let colorExample: Color = Color.Blue;
console.log(colorExample); //Green output = 1, Blue output = 12


//String enums
enum CardinalDirections{
    North = "NORTH",
    East = "EAST",
    South = "SOUTH",
    West = "WEST"
}

let direction: CardinalDirections = CardinalDirections.North;
console.log(direction); //output = NORTH


// Any
//Any type lets you opt out of typechecking
    //this gives you loose typing just like in JS

let notSure: any = 5;
notSure = "Hello";
notSure = false;


//void
//the void type is used for functions that do not return a value

function sayHello() : void{
    console.log("Hello");
}

//never
//never represents alues that never occur
//it is used for functions that always throw an error or never return a alue

function error(message: string): never {
    throw new Error(message);
}