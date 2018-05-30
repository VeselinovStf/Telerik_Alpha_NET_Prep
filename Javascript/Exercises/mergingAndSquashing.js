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
    '11',
    '44',
    '69',
    '46',
    '63',
    '83',
    '13',
    '62',
    '14',
    '31',
    '68',
    '87',
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const n = +gets();
let merged = [];
let squashed = [];

let firstNum = +gets();
for (var i = 0; i < n - 1; i += 1) {
    let nextNumber = +gets();

    merged.push(MergeNumbers(firstNum, nextNumber));
    squashed.push(SquashNumber(firstNum, nextNumber));

    firstNum = nextNumber;
};

PrintArray(merged);
PrintArray(squashed);

function MergeNumbers(firstNum, nextNumber) {
    let newNumber;
    let b = firstNum % 10;
    let c = Math.trunc(nextNumber / 10);
    newNumber = b * 10 + c;

    return newNumber;
}

function SquashNumber(firstNum, nextNumber) {
    let newNumber;
    let a = Math.trunc(firstNum / 10);
    let b = firstNum % 10;
    let c = Math.trunc(nextNumber / 10);
    let d = nextNumber % 10;

    let middleDigit = b + c;
    if (middleDigit >= 10) {
        middleDigit = middleDigit % 10;
    }
    newNumber = (a * 100) + (middleDigit * 10) + d;


    return newNumber;
}

function PrintArray(array) {
    let output = "";
    for (var i = 0; i < array.length; i += 1) {
        output += array[i] + " ";
    };
    print(output);
}