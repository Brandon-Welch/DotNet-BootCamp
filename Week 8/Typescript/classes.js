//Classes
/*
CXlasses in TRS are a blueprint for creating objects with predefined properties and methods
TS classes support things like:
    Inheritance
    Access Modifiers
    Constructors

*/
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Animal = /** @class */ (function () {
    function Animal(name) {
        this.name = name;
    }
    Animal.prototype.move = function (distance) {
        console.log("".concat(this.name, " moved ").concat(distance, " feet."));
    };
    return Animal;
}());
var Dog = /** @class */ (function (_super) {
    __extends(Dog, _super);
    function Dog(name) {
        return _super.call(this, name) || this;
    }
    Dog.prototype.bark = function () {
        console.log("Woof! Woof!");
    };
    return Dog;
}(Animal));
var dog = new Dog('Buddy');
dog.bark();
dog.move(10);
//Casting
//Castring is when you tell mthe compiler to treat a variable as a differnt type
var someValue = "This is a string.";
var strLength = someValue.length;
// Union types
//allow a variable to be one of several types
var unionValue;
unionValue = "hello!"; //correct
unionValue = 42; //correct
var move;
move = "north"; //correct
// move == "up"; //error
//type guards
function isNumber(value) {
    return typeof value === "number";
}
function printValue(value) {
    if (isNumber(value)) {
        console.log(value.toFixed(2));
    }
    else {
        console.log(value.toUpperCase());
    }
}
//generics
/*
    Generics provide a way to create resubale components that work with a variety of types

    these can be functions, classes, methods, etc
*/
//generic function
function identity(arg) {
    return arg;
}
var output1 = identity("Hello");
var output2 = identity(35);
//generic class
var Box = /** @class */ (function () {
    function Box(field) {
        this.field = field;
    }
    return Box;
}());
//array generics
function getArray(items) {
    return new Array().concat(items).sort();
}
var numArray = getArray([134, 2342, 32, 124]);
var strArray = getArray(["aas", "ber", "casdf"]);
console.log(numArray);
console.log(strArray);
