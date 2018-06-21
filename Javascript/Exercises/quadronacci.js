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
  '2',
  '3',
  '4',
  '2',
  '8'
  
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

let f1 = +gets();
let f2 = +gets();
let f3 = +gets();
let f4 = +gets();

const row = +gets();
const col = +gets();

let totalQuadronacci = col * row;

let numbers = [];
numbers.push(f1);
numbers.push(f2);
numbers.push(f3);
numbers.push(f4);


for (let i = 0; i < totalQuadronacci-4; i++) {
    let quadronacci = f1+ f2+f3+f4;
    numbers.push(quadronacci);

    var tempF2 = f2;
    f1=tempF2;
    var tempF3 = f3;
    f2=tempF3;
    var tempF4 = f4;
    f3= tempF4;
    f4= quadronacci;

}

var count = 0;
for (let r = 0; r < row; r++) {
    var line = "";
    for (let c = 0; c < col; c++) {
        
        line+= numbers[count] + " ";
        count++;
    }
    print(line);
}
