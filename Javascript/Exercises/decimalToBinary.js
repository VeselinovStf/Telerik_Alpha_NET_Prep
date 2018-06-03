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
'0'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

let number = +gets();

let binary = ConvertDecimalToBinary(number);
print(binary);

function ConvertDecimalToBinary(number){
    let decimal = [];

    if (number == 0) {
        return 0;
    }
    while(number > 0) {
        
        if ((number & 1) == 0) {
            decimal.push('0');
        }    
        else{
            decimal.push('1');
        }
        number  = number >>> 1;
        
    };

    return decimal.reverse().toString().replace(/,/g, '');
}