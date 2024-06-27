//Classes
/*
CXlasses in TRS are a blueprint for creating objects with predefined properties and methods
TS classes support things like:
    Inheritance
    Access Modifiers
    Constructors

*/

class Animal {
    private name: string;

    constructor(name: string){
        this.name = name;
    }

    public move(distance: number): void {
        console.log(`${this.name} moved ${distance} feet.`)
    }
}

class Dog extends Animal {
    constructor(name: string){
        super(name);
    }

    public bark(): void{
        console.log("Woof! Woof!");
    }
}

const dog = new Dog('Buddy');
dog.bark();
dog.move(10);


//Casting
//Castring is when you tell mthe compiler to treat a variable as a differnt type

let someValue: any = "This is a string.";
let strLength: number = (someValue as string).length;


// Union types
//allow a variable to be one of several types
let unionValue: string | number;
unionValue = "hello!"; //correct
unionValue = 42; //correct
//unionValue = false; //error

//TODO: See Brian's notes as I got lost!
///Interfaces and Type Aliases
    //Interface
    //let you defind the structure of an object

    //Type Aliases
    //let you create a new name for a type

//literal types
//this lets you specify exact values a variable can be

type Direction = "north" | "south" | "east" | "west";

let move: Direction;
move = "north"; //correct
// move == "up"; //error

//type guards
function isNumber(value: any): boolean {
    return typeof value === "number";
}

function printValue(value: string | number) {
    if(isNumber(value)) {
        console.log((value as number).toFixed(2));
    }
    else {
        console.log((value as string).toUpperCase());
    }
}

//generics
/*
    Generics provide a way to create resubale components that work with a variety of types

    these can be functions, classes, methods, etc
*/

//generic function
function identity<T>(arg: T): T{    //T stands for "Type", its a community standard liek I J K, but not required... just preferred
    return arg;
} 

let output1 = identity<string>("Hello");
let output2 = identity<number>(35);

//generic class
class Box<T> {
    
    private field: T;

    constructor(field: T){
        this.field = field;
    }
}

//array generics
function getArray<T>(items: T[]): T[] {
    return new Array<T>().concat(items).sort();
}

let numArray = getArray<number>([134, 2342, 32, 124]);
let strArray = getArray<string>(["aas", "ber", "casdf"]);

console.log(numArray);
console.log(strArray);