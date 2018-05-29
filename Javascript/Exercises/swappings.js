/*
    FIX MEMORY LIMIT

*/

const getGets = (arr) => {
    let index = 0;

    return () => {
        const toReturn = arr[index];
        index += 1;
        return toReturn;
    };
};
// this is the test
const test = [
  '12',
  '11 5 10 6 9 10',
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const arraySize = +gets();
const movements = gets().split(' ').map(Number);

let array = FillArray(arraySize);

for (var i = 0; i < movements.length; i+=1) {
    var currentMove = movements[i];

    var indexToCurrentPoint = array.indexOf(currentMove);
    
    let newArr = MoveElements(array, indexToCurrentPoint);
    array = newArr;
};

print(ArrayToString(array));

function MoveElements(array, indexToCurrentPoint){
    let arr = [];

    for (var i = indexToCurrentPoint + 1; i < array.length; i+=1) {
        arr.push(array[i]);
    };

    arr.push(array[indexToCurrentPoint]);

    for (var i = 0; i < indexToCurrentPoint; i+=1) {
        arr.push(array[i]);
    };
   
    return arr;
};

function FillArray(arraySize){
    let array = [];
    for (var i = 0; i < arraySize; i+=1) {
        array[i] = i+1;
    };

    return array;
}

function ArrayToString(array){
    var result = "";

for (var i = 0; i < array.length; i+=1) {
    if (array[i] != " " && array[i] != ",") {
        result += array[i] + " ";
    }
};

    return result;
}