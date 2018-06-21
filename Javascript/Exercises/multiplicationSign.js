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
  '2',
  '5',
  '-2',
  
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

let fNumber = +gets();
let sNumber = +gets();
let tNumber = +gets();

if(fNumber == 0 || sNumber == 0 || tNumber == 0){
    print(0);
}
else if(
    (fNumber < 0 && sNumber > 0 && tNumber > 0) ||
    (sNumber < 0 && fNumber > 0 && tNumber > 0) ||
    (tNumber < 0 && fNumber >0 && sNumber > 0) ||
    (fNumber < 0 && sNumber < 0 && tNumber < 0)
    )
    {
    print("-");
}
else{
    print("+");
}


