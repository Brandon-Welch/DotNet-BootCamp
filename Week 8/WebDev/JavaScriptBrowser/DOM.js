// Document Object Model
/*
    This acts as an object representation of the HTML document so that w can programatically interact with the webpage

    This is essentially an interface that lets us interact, manupulate, remove, or add things to the document structure, style, and content.

    The DOM is a tree like structure, where every node represents an element or a piece of content in the document
*/

console.log(document);

//Element Selectors
/* 
    In order to manipulate the DOM, you need to be able to select items from the DOM.

    There are several methods, some follow a new syntax, others follow the CSS syntax

*/

// Select by ID
const header = document.getElementById('header');
console.log(header); //this will print the header in the console

// Select by class name
const intro = document.getElementsByClassName('intro');
console.log(intro); //this will print the intro as a COLLECTION in the console

// Select by tag name
const paragraphs = document.getElementsByTagName('p');
console.log(paragraphs); //this will print the paragraph as a COLLECTION in the console

// Select using CSS selectors
// We are using the CSS syntax for selecting content as the id is content so we use the #content
// if we are trying to select a class, it would be .intro
const content = document.querySelector('#content');
const allParagraphs = document.querySelectorAll('p');
console.log(content); //this will print the content in the console
console.log(allParagraphs); //this will print the allParagraphs as a NodeList in the console


// DOM Manipulation
// Once we have selected an element, you can manipulate it by changing its properties, attributes, and content.

// Change content
header.textContent = 'Hello, World!'; //this will update the header from "Welcome to My Webpage" to Hello World! in the site document.

// Change style
header.style.color = 'blue'; //this will update the header color from default to 'Blue" in the site document.

// Add a new class
header.classList.add('highlight');  //this add the CLASS "highlight" to the header... so if we created highlight class and made updated there, it would update the header based on the changes directly to header.

// Remove an element
const button = document.getElementById('myButton');
button.remove(); //this will update/delete the 'Click Me' button in the site document.

// Create and append a new element
const newParagraph = document.createElement('p');
newParagraph.textContent = 'This is a new paragraph.';
document.body.appendChild(newParagraph); ////this will update/add a new paragraph in the site document.
const newButton = document.createElement('button');
newButton.textContent = "New Button!";
document.body.appendChild(newButton); ////this will update/add a new button in the site document.


// Traversing DOM
/*
    DOM traversal allows you to navigate between elements in the DOM tree.
*/
const contentDiv = document.getElementById('content');

// Parent node
//node is like wrist, fingers are like elements?
const parent = contentDiv.parentNode; 
console.log(parent); //this will print the parent in the console (includes everything on page_)

const parentElement = contentDiv.parentElement;
console.log(parentElement); //this will print the parentElement in the console

// Child nodes
const children = contentDiv.childNodes;
console.log(children); //this will print the children in the console

const childrenElements = contentDiv.children;
console.log(childrenElements); //this will print the childrenElements in the console 


const paragraph1 = childrenElements[0];
const parentParagraphNode = paragraph1.parentNode;
const parentParagraphElement = paragraph1.parentElement;
console.log(parentParagraphNode);
console.log(parentElement);
/*
// only removing every other 
for(const paragraph of childrenElements)
{
    console.log(paragraph);
    paragraph.remove();
}
*/

/*
//works but bobbi found a simpler way
for(let i = childrenElements.length - 1; i >= 0; i--){
    childrenElements[i].remove();
}
*/

// while(contentDiv.firstChild) {
//     contentDiv.removeChild(contentDiv.firstChild);
// }

// First child
const firstChild = contentDiv.firstChild;

// Last child
const lastChild = contentDiv.lastChild;

// Sibling nodes 
//have to have same parent to be siblings
const nextSibling = contentDiv.nextSibling;
const previousSibling = contentDiv.previousSibling;

// Events and Listeners
/*
    JavaScript can respond to user interactions by listening for events and executing functions when those events occur.
    
    Events: Anyway that a user can interact with your page can be isolated as an event (clicking, hovering, highlighting, typing etc)

    Listeners: We can attach a Listener to any Event, this can trigger something else (log, etc)
*/

// Select the button
// BC I am geting elementsbytagname, this will be default return an array of elements even if there is only one elemtn, so we will use the [0] to grab the first element from that collection

//const newButtonSelected = document.getElementById('myButton'); //this button was deleted in earlier steps, so code wont work
const newButtonSelected = document.getElementsByTagName('button')[0]; //setting newbuttonSelected to the button in the array at the 0 index (the new button that was create above)
console.log(newButtonSelected); //sanity check

// Define a function to run when the button is clicked
 function handleClick() {
     alert('Button was clicked!');
 } //this makes a popup in the browser once the button is cliked, but needs the listener before it will work.

// Add an event listener to the button
//the Syntax of the addEventListener is ('event_name', 'function_name')
 newButtonSelected.addEventListener('click', handleClick); //this triggers the function aboveto make the actual alert pop up.

 // Bubbling and Capturing
 /*
    Event propagation in the DOM has two main phases: capturing and bubbling.

    Capturing: The event starts from the root and propagates down to the target element.
    Bubbling: The event starts from the target element and propagates up to the root.
    You can specify the phase in which to handle the event by adding a third parameter to addEventListener.
 */

// Capturing phase
document.body.addEventListener('click', function() {
    console.log('Body clicked (capturing)');
}, true);

// Bubbling phase
document.body.addEventListener('click', function() {
    console.log('Body clicked (bubbling)');
}, false);

//Fetch API
/*
    The Fetch API provides a way to make network requests similar to XMLHttpRequest. 
    It is more powerful and flexible.
    It works wiht JSON and all the HTTP methods
*/

// Fetch data from an API
/*
    We want to get data from an API
    In order to get that data, we need the following:
        -URL
        -HTTP Method (GET/POST...etc)

    Once we get some kind of response
        -Check if the response is OK
        -If there is JSON, turn it into a java script object
*/

//promises appraoch
/*
    When you create a promise, there are 3 states that it can exist in
        
        Pending - This is in the process of being completed 
        Completed Successfully
        Completed Unsuccessfully

    Need to be able to handle them all asyncronously
*/
//fetch('https://api.example.com/data') //FETCH by default, this is a GET method... you would have to change the Method on the call if you want a different method
fetch('https://pokeapi.co/api/v2/pokemon/1')
    .then(response => response.json()) //if Completed Successfully
    .then(data => {
        console.log(data); //***will return the object in the Console (balbasaur)***
    })
    .catch(error => { //if Completed Unsuccessfully
        console.error('Error:', error);
    });

// Using async/await for fetching data
async function fetchData() { //this lets us write things out more like code as this is like a method so it will need to be called before it runs
    try {
        //let response = await fetch('https://api.example.com/data');
        let response = await fetch('https://pokeapi.co/api/v2/pokemon/1'); //await keyword is imporant! needs to be infront of any asyncronoush request, its what sends the .then request. it will not move on until the response coems back from the fetch. almost like pausing the code
        let data = await response.json(); //again, wontgo below line until this response finishes
        console.log(data); //logs to the Console
    } catch (error) {
        console.error('Error:', error);
    }
}

fetchData(); //calls the function fetchData from above