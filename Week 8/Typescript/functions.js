// Functions in TS are similiar to JS
//we have the ability now though to have typed paramanetrs and return types
//regular funciton
//function reference(param: type): returnType{}
function addNumbers(x, y) {
    return x + y;
}
var sum = addNumbers(3, 5);
console.log(sum); //output = 8
//Arrow syntax
//Arrow functins provide a more concise syntax lexically (keeps it within the definition of the function itself) bind this value
var multipleNumbers = function (x, y) {
    return x * y;
};
//Anonymous Functions
//These are functions without a name, often used as arguments to other functions
//You can pass a function, as a paramanet
setTimeout(function () {
    console.log("This is an anonomyous function");
}, 1000);
setTimeout(function () {
    console.log("This is an arrow anonymous function");
}, 1000);
function concatenate(x, y) {
    return x + y;
}
var stringResult = concatenate("hello ", "world"); //output = hello world
var numberResult = concatenate(5, 10); // output = 15
//Optional and Default parameters
//Optional Parameters
//these are specified with a ?
function greetPerson(name, greeting) {
    if (greeting) {
        return "".concat(greeting, ", ").concat(name);
    }
    else {
        return "Hello there, ".concat(name);
    }
}
//Default Parameters
//these provide a way to provide a default value if nothing is given
function greetDetault(name, greeting) {
    if (greeting === void 0) { greeting = "Hello"; }
    return "".concat(greeting, ", ").concat(name);
}
//Rest parameters
//this allows a function to accept an indefinte number of arguments as an arry
//rest parameter, must be the last parament
function summing(greeting) {
    var numbers = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        numbers[_i - 1] = arguments[_i];
    }
    var total = numbers.reduce(function (total, num) { return total + num; }, 0);
    return "".concat(greeting, ", your total is: ").concat(total, ".");
}
console.log(summing('Mike', 3, 4, 5, 6, 7, 8, 10));
