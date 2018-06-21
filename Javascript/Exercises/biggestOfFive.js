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
  '-0.5',
  '-10',
  '100',
  '-1',
  '-3'
  
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

let biggest = +gets();
for (let i = 0; i < 4; i++) {
    let number = +gets();
    
    if (number > biggest){
        biggest = number;
    }

}

print(biggest);