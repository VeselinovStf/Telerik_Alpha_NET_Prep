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
  '7',
  '1',
  '1',
  '10000'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const size = +gets();

var output = "";
for (var i = 0; i < size; i+=1) {
    
    for (var j = 0; j <= i ; j+=1) {
        output +=  j + 1 + " ";
    };
    print(output);
    output = "";
};

for (var i = 0; i < size - 1; i+=1) {
    
    for (var j = 0; j <= size - i -2; j+=1) {
        output += j + 1 + " ";
    };
    print(output);
    output = "";
};