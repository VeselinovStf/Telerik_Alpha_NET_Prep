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
  '6',
  '-26 -25 -28 31 2 27',
  '123 -3',
  '4 -150',
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const size = +gets();
const array = gets().split(' ').map(Number);

let totalNeighbours = GetFirstNeigborIndex(array);

function GetFirstNeigborIndex(array){
    for (var i = 1; i < array.length -1; i+=1) {
        var currentNeighbour = array[i];
        var left = array[i-1];
        var right = array[i+1];
    
        if (currentNeighbour > left && currentNeighbour > right) {
            return i;
        }
    };

    return -1;
}
print(totalNeighbours);