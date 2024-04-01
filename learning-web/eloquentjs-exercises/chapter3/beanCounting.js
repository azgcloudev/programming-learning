const countBs = (string) => {
    const length = string.length;
    let bCounter = 0;

    for (let i = 0; i < length; i++) {
        if (string[i] === "B") {
            bCounter += 1;
        }
    }

    return bCounter;
}


const countChar = (string, letter) => {
    const length = string.length;
    let charCounter = 0;

    for (let i = 0; i < length; i++) {
        if (string[i] === letter) {
            charCounter += 1;
        }
    }

    return charCounter;
}