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
    '4',
    '3 1112 11 212 22 12 1121101 12201 201100111',
    
]
const gets = this.gets || getGets(test);
const print = this.print || console.log;

const totalNums = +gets();
const array = gets().split(' ').map(Number);

let biggestNumber = 0;
for (var i = 0; i < array.length-1; i+=1) {
    if (array[i] > biggestNumber) {
        biggestNumber = array[i];
    }
};

let result = "";
result += biggestNumber;
let count = result.length;
for (var i = count-1; i >=0 ; i-=1) {
    result+= result[i];
};
print(result);

// 201100111 111001102