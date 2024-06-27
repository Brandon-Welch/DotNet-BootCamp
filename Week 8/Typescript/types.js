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
var isDone = false;
var age = 26;
var firstName = 'John';
var u = undefined;
var n = null;
// Yoiu cannot reassign a valyue to somethign that does not match its declared datatype
//isDone = "Hello"; // cannot assign boolean a string
// you can do this, and still run the transpiler to get the JS and the JS file will still work
//however, this kind of behaviopr defeats the point of having the typescript in the first place
//Arrays
// Syntax:
// type[] or Array<type>
//the typing allows us to have typesaftey in our arrays
var numberList = [1, 2, 3];
var genericNumberList = [1, 2, 3];
// Tuple (unique to typescripts)
// Tuples let you define an array wiht fixed types and length
var tupleExample;
tupleExample: ["Hello", 50]; //correct
//tupleExample: [10, "Hello"]; //error
//Enums
//Enums allow you to define a set of named constants
//numerical Enum
// basically you can think of this as a predefined array where indexes are actualy values
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 12] = "Blue"; //assigned index [12]
})(Color || (Color = {}));
var StatusCodes;
(function (StatusCodes) {
    StatusCodes[StatusCodes["Ok"] = 200] = "Ok";
    StatusCodes[StatusCodes["Created"] = 201] = "Created";
    StatusCodes[StatusCodes["NotFound"] = 404] = "NotFound";
})(StatusCodes || (StatusCodes = {}));
var colorExample = Color.Blue;
console.log(colorExample); //Green output = 1, Blue output = 12
//String enums
var CardinalDirections;
(function (CardinalDirections) {
    CardinalDirections["North"] = "NORTH";
    CardinalDirections["East"] = "EAST";
    CardinalDirections["South"] = "SOUTH";
    CardinalDirections["West"] = "WEST";
})(CardinalDirections || (CardinalDirections = {}));
var direction = CardinalDirections.North;
console.log(direction); //output = NORTH
// Any
//Any type lets you opt out of typechecking
//this gives you loose typing just like in JS
var notSure = 5;
notSure = "Hello";
notSure = false;
