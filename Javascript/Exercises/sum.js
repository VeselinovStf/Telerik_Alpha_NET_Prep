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
  '12 1 95',
  '1',
  '1',
  '10000'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const array = gets().split(" ").map(Number);

array.sort();
const sum = array[0] + array[array.length -1];
print(sum);