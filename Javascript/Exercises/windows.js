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
    '3 2',
    '10 20 1',
    '30 40 0',
    '20 20 1'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const params = gets().split(' ').map(Number);
const windowsCount = params[0];
const price = params[1];

let totalPrice = 0;
for (var i = 0; i < windowsCount; i += 1) {
    const windowProps = gets().split(' ').map(Number);

    if (windowProps[2] == 1) {
        //calculate
        totalPrice += (windowProps[0] * windowProps[1]) * price;
    }
};

print(totalPrice);