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
  '1',
  '1',
  '1',
  '10000'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

let firstN = +gets();
let secondN = +gets();
let thirdN = +gets();

const tribonaciN = +gets();

let finalTribonaci = 0;

if (tribonaciN == 1 ) {
    finalTribonaci = firstN;
}
else if (tribonaciN == 2 ) {
    finalTribonaci = secondN;
}
else if (tribonaciN == 3 ) {
    finalTribonaci = thirdN;
}
else{
    for (var i = 3; i < tribonaciN; i+=1) {
        finalTribonaci = firstN + secondN + thirdN;
    
        //var tempOne = firstN;
        var tempTwo = secondN;
        var tempThree = thirdN;
    
        firstN = tempTwo;
        secondN = tempThree;
        thirdN = finalTribonaci;
    };
    
}

print(finalTribonaci);