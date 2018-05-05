function numbersFromString(str) {
    let count = Number(str);
    let result = '';
    for (var i = 1; i <= count; i++) {
        result += i;
    }

    return result;
}

console.log(numbersFromString("11"));