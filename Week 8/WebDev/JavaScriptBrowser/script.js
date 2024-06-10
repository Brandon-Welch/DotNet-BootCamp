console.log("Hello World! (basic console.log)");

//Data Types
/*
    In statically typed languages like C#, you must declare the data type of the variable first before you can even assign something to it
        string name ="Mike";
        name = 3;


    primitive types
        string
        number
        boolean
        null
        undefined
        symbol
        bigint

    reference types
        object
        array
        function
*/

let name = "John"; //string
let age = 30; //number
let isStudent = false; //boolean
let car = null; //null
let address; //undefined

let uniqueID = Symbol("1"); //Symbol is used to create unique things even with the same values
let uniqueID2 = Symbol("1");
let largeNumber = 1324564654874854654846544687468n; //bigInt
console.log((uniqueID == uniqueID2) + " (this is from comparing symbols)");

// You can reassign variables to any data, it is loosely typed

age = "50";

console.log(name + " (name)");
console.log(age + " (age)");
console.log(address + " (address)");



//reference types
    //object
    //the syntax is very similiar to JSON
    //it begins with {} and the properties inside of it follow a key/value pair
    let person = {
        name: "John",
        age: 30
    };
    console.log(person);

    //array
    //Arrays can have any data type within it, it is not restricted
    //generally it is recommended to stick to one, but if you need multiple, that is fine
    let hobbies = ["reading", "writing", 32342, null];
    console.log(hobbies);

    //function
    //similiar to Methods, if your going to use something alot, make it a function
    //you dont define what it returns
    //just use function, the name of the function and the paramanets
    function great(){
        console.log("Hello (from function)");
    }
    great(); //calls it in the console 


// Type Coercion
/*
    JavaScript will automatically convet values from one type to another when neccessary.
    This is type coercion, and can lead to unexpected results if not handled correctly
*/
console.log(("6" + 6) + " (Coerced from a string 6 + number 6)"); //string
console.log("5" - 2); //number
console.log("5" * "2"); //number
console.log("five" * 2); //Nan (Not a Number)

//typeof
//you can use the typeof operator to check what the datatype of a variable is
console.log(typeof 5 + " " + typeof "person" + " " + typeof person + " (can tell you the type of the variable)");

//Variable Scopes

    //Function Scope
        //Variables declared inside of a function is scoped ot that function
    //Block Scope
        //varibale sdeclared with let or const are scoped to the block in which they are defined (as in the curly braces {} )

    /*
    There are 3 ways to declare a variable in JavaScript
    The first way, was the first to be introduced into the language when it was creade
    
        1) var - (similiar to let)
            -var does something called variable hoisting
            -anything declared with 'var', when it is ran, all the declarations will be "brought" to the top of the page, but not hte initialization
            -so the variable can be referenced after it has been declared, but it will be undefined. this leads to broken code most of the time
                ex:
                var name2 = "let";

                what happens is:
                var name2; is brought ot the top

                only later does:
                name2 = "let"; get initialized, so if you tried to console.log(name2) before its initialized, it will reutrn 'undefined'
        
        2) let/const

        *anything declared wiht Let and/or Const has block scope. you cannot reference outside of the scope that it is declare within
        *let and const have other properties
            let is basically the default declarration for a variable
            it lets anything declared with it be reassigned
            it also lets you declare it without initializing a variable (dont have to assign a value to it)
        
                const is used for constants,
                when a value has been assigned, it cannot be reassigned to something else
                anything declared with const must be initialized, you cannot have undefined values for consts
    */

    //Arrays
    /*
        used to store muultiple values in a single variable
        they also provide various methods for adding, removing, and manipulating elements
    */

    let fruits = ["apple", "banana", "orange"];

    //acces the values insde the array with indexes
    console.log(fruits[0]); //prints apple
    //add an element to the end of an array
    fruits.push("grape");
    console.log(fruits);
    //remove the last element of an array
    fruits.pop();
    console.log(fruits);


    //For Loops
    //There are 3 ways to loop in a for loop type way in JS
    for(let i = 0; i < fruits.length; i++)
        {
            console.log(fruits[i]);
        }

    for (const element of fruits) //go through each value of the array.object
        {
            console.log(element); //prints the values
        }

    for (const key in fruits) //go through each key of array/object
        {
            console.log(key); //prints out key values (indexes)
        }

    for (const key in person)
        {
            console.log(key);
        }

    for (const key in person)
        {
            console.log(person[key]); //prints the actual values of the object since its in the function and using the []
        }


//Functions
/* 
    These are blocks of code designed to perform a particulare task.
    They can be defined using the function keyword as a function 
    exrpessions
*/

function greetPerson(name)
        {
            return "Hello, " + name + "!";
        }
console.log(greetPerson("Mike"));

//Function Expressions
let greetPersonExpression = function(name)
        {
            return "Hello, " + name + "!"
        }

    greetPersonExpression = function(name)
    {
        return "Hello Again, " + name + "!"
    }
console.log(greetPersonExpression("Jim"));


//OOP
/*
    OOP is supported somehwat in JS
    The language already has objects in it, but there is no in built class featuers
    This is what we call syntactic sugar, where we have syntaxes that look like it is doing something, but when it runs through compilre, its converted into something else
*/
class Person
    {
        constructor(name, age)
        {
            this.name = name;
            this.age = age;
        }

        greet()
        {
            console.log("Hello, my name is " + this.name + "." + " I am " + this.age + ".")
        }
    }   

const john = new Person("John", 30);

john.greet();
console.log(john)

// this keyword
/*
    this referes to the current context in which a function is executed
    its value depends on how a function is called

    if the function is inside of an object, this refers to the object that is being called

    if the function is outside of an object, this refers to the global object which is the browser
*/

function globalGreet()
{
    console.log(this);   
}
globalGreet();

//Arrow Functions
/*
    Arrow functions provide a shorter syntax for writing functions
    they are especially userful for inline functions
    they also have a unique property in which htey do not bind their own this
*/

//function expression
let add = function(param1, param2)
{
    return param1 + param2;
};

//it will implicitly return the value on the right side of the function
add = (param1, param2) => param1 + param2;

console.log(add(1,2));


const Mike = {
    name: "Mike",
    greet: () => {
        console.log("Hello, my name is " + this.name);
    }
};

Mike.greet();