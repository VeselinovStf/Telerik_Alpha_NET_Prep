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
    '100000'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

let n = +gets();
let i = 1;
let result = 0;

while (true) {
    n = n / 5;
    result += n | 0;

    if (n <= 1) {
        break;
    }
}

print(result | 0);
//const f = +gets();
//
//
//    let trailingZeroes = GetTrailingZeroes(f);
//    
//    print(Math.trunc(trailingZeroes));
//
//function GetTrailingZeroes(value){
//    let zeroes = 0;
//
//    for (var i = 5; value/i >= 1; i*=5) {
//        zeroes += value/i;
//    };
//
//    return zeroes;
//}
