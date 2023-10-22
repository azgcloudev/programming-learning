const isEven = number => {

    // converts negative numbers in positive
    const numberAbs = Math.abs(number);
    
    if (numberAbs === 0)
        return true;
    else if (numberAbs === 1)
        return false;
    else
        return isEven(numberAbs - 2);
}