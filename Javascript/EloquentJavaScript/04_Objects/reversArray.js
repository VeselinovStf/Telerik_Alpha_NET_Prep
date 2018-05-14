function reversArray(array) {
    var reversed = [];
    for (let index = array.length - 1; index >= 0; index -= 1) {
        reversed.push(array[index]);
    }
    return reversed;
}

function reverseInPlace(array) {
    for (let index = 0; index < array.length / 2; index++) {
        var temp = array[array.length - 1 - index];
        array[array.length - 1 - index] = array[index];
        array[index] = temp;
    }
}

var arr = [1, 2, 3, 4, 5];

console.log(reversArray(arr));
console.log(reverseInPlace(arr));
console.log(arr);
