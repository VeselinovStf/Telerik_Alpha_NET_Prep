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
    
    '1010101010101011'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const binary = gets();

let decimal = 0;
for (var i = binary.length-1; i >= 0; i-=1) {
    
     decimal += binary[binary.length - 1- i]* Math.pow(2,i);
};

print(decimal);