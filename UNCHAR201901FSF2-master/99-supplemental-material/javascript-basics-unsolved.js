/* use vanilla javascript */

// declare a variable for each of these data types:

    // string
    var string1 = "bob";
    // number
    var numberTwo = 2;
    // boolean
    var boolean = true; // false
    // array with at least 3 strings in it
    var arrayOne = ["3000", "three-thousand", "penn, too"];
    // object with at least 2 properties (key/value pairs), with string values
    var cookiesObj = {
        chip: "vanilla cream",
        flavor: "punkin spice"
    };

    // ==, ===
    2 == 2; // true
    2 === 2; // true
    2 == '2'; // true
    2 === '2'; // false

// place the string from the string variable above onto the DOM, inside the <div> with the ID of "string-goes-here" 

    // grab div with ID of "string-goes-here"
    var stringGoesHere = document.getElementById("string-goes-here");

    // paste the string in
    stringGoesHere.innerHTML = string1;

// console log your number variable
console.log(numberTwo);

// add 2 to your number variable, and console log the result
console.log(numberTwo + 2);
console.log(numberTwo); // 2


numberTwo += 2; //4
numberTwo = numberTwo + 2;//6
console.log(numberTwo);

// write an if/else condition based on what you chose for your boolean.
    if (boolean) {
        // if true, console log "my boolean is true"
        console.log("my boolean is true");
    } else {
        // else console log "my boolean is false"
        console.log("my boolean is false");
    }


// console log how many items are in your array
console.log(arrayOne.length); // 3

// add your string variable to your array
arrayOne.push(string1);

// console log how many items are now in your array
console.log(arrayOne.length); // 4

// for each string in your array...
    // for (~declaration~; ~conditional~; ~action~)
    // make declaration
    // check conditional
        // if true, run the code in the {}
            // after running the code, will run action
            // check against conditional again
        // if false, move on
    for (var i = 0; i < arrayOne.length; i++) {

        // create a list item element...
        var newLi = document.createElement('li');
        // set style attribute to the item you just created, and set the background color to green
        // BONUS: set background color to orange if it is an odd number
        var currentNumber = i + 1;
        if (currentNumber % 2 === 0) {
            newLi.style.backgroundColor = 'green';
        } else {
            newLi.style.backgroundColor = 'orange';
        }
        
        // put the string into the list item you just created...
        newLi.innerHTML = arrayOne[i];
        
        // add the list item to the DOM, inside the <ul> with the ID of "arrayItemsHere"
        var unorderedList = document.getElementById('arrayItemsHere');

        unorderedList.appendChild(newLi);
    }
        
// set your array variable to a new property in your object
