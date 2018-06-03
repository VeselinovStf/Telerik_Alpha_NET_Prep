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
'0',
'4',
'20',
'1337',
'2147483648',
'4000000000',
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const binaryDigit = +gets();
const inputCount = +gets();

for (var i = 0; i < inputCount; i+=1) {
    let decimalNumber = +gets();
    let digitsCount = GetDigitsCount(decimalNumber, binaryDigit);

    print(digitsCount);
};

function GetDigitsCount(number, binaryCompare){
    let count = 0;
    let remainder;

    while (number > 0)
    {
        if ((number & 1) == binaryCompare)
        {
            count++;
        }
        number = number >>> 1;
    }

    return count;
}