var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];


function range(array, start, end) {
    var result = [];
    var step = 1;

    if (arguments[3] != undefined) {
        step = arguments[3];
    }

    if (step > 0) {
        for (let index = start; index < end; index+= step) {
            result.push(arr[index]);           
        }
    }
    else  {
        for (let index = start; index >= end; index-= Math.abs(step)) {
            result.push(arr[index]);              
        }
    }
    

    return result;
}

function sum(array) {
    var sum = 0;
    for (let index = 0; index < array.length; index++) {
        sum += array[index];      
    }
    return sum;
}

console.log(range(arr,9,1,-5));
console.log(sum(arr));