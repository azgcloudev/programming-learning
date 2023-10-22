"use strict";

// variable to display the symbol that will be use in the tree
const symbol = "#";

// function that will console the symbols quantity in a single line
const printSymbol = (symbol, quantity) => {
    let result = "";
    for (let i = 0; i < quantity; i++) {
        result += symbol
    }
    console.log(result);
}

// loop to display in the console the tree of the maximum quantity needed (hadcoded 7)
for (let i = 1; i <= 7; i++) {
    printSymbol(symbol, i);
}