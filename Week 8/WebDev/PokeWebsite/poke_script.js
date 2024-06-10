const searchContainer = document.querySelector("#search-container");
const displayContainer = document.querySelector("#display-container");
//console.log(searchContainer); //confirmed it showed in console
//console.log(displayContainer); //confirmed it showed in console

const inputNumber = searchContainer.children[0]; //creates reference to the 1st [0 index] element inside the searchContainer division container (which is the input type = "number")
const searchButton = searchContainer.children[1];
//console.log(inputNumber); //confirmed it showed in console
//console.log(searchButton); //confirmed it showed in console


//async function to communicate with Poke API

//function that takes in the search input for the search container
function getSearchNumber()
    {
        let pokeId = inputNumber.value;
        getPokemon(pokeId);
    }

//Event Listener for "Enter" key
    inputNumber.addEventListener('keypress', (event) => {
    if (event.key === 'Enter') 
        {
            getSearchNumber(); //Performs the desired action upon button click
        }
    });

//Event Listener for Button Click
searchButton.addEventListener('click', getSearchNumber); //when button is clicked, calls the getSearchNumber function


//async function to actually talk to the api
async function getPokemon(pokeId)
    {
        const URL ="https://pokeapi.co/api/v2/pokemon/" + pokeId;

        try 
        {
            let response = await fetch(URL);
            let data = await response.json();
            console.log(data);
            console.log(data.name);
            console.log(data.sprites.front_default);
            displayPokemon(data.name, data.sprites.front_default);
        } 
        
        catch (error) 
        {
            console.error(error)    
        }
    }

function displayPokemon(name, imgUrl)
    {
        //First we are clearing anything that is inside of the container
        //this preventrs us from duplicating anything
        while(displayContainer.firstChild) 
        {
            displayContainer.removeChild(displayContainer.firstChild);
        }

        //Next, we create the elements that we want to display to the page
        //we are using an h3 element for the name of the pokemon
        let pokeName = document.createElement("h3");
        pokeName.textContent = name;

        //we are using an image element for the poke image
        let pokeImage = document.createElement("img");
        pokeImage.src = imgUrl;

        //creating the elemtns and assing them to the neede properties is not enough to display on the page
        //we need to append it as a child of the container in order for it to showup to the webpage
        displayContainer.appendChild(pokeName);
        displayContainer.appendChild(pokeImage);
    }

//function that takes in search input for the search-container


/*
Things needed:
    Takes user input
    Searches for a pokemon
    Display requested pokemon

*/