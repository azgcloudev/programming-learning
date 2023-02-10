const min = (num1, num2) => {
    let min;

    if (num1 === num2)
        return num1;
    else if (num1 > num2)
        return num2;

    return num1;
}

console.log(min(-89, -3));