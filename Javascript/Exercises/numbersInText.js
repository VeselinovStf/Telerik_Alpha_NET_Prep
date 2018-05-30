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
    'D2h40go'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const array = gets().split("");
let sum =0;
let gotNum = false;
for (var i = 0; i < array.length; i+=1) {
    if (!isNaN(parseInt(array[i]))) {
        gotNum = true;
        sum+= parseInt(array[i]);
    }
};

if (gotNum) {
    print(sum);
}
else   {
    print(-1);
}