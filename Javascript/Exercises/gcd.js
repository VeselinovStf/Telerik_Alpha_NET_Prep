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
    '60 40',
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const numbers = gets().split(' ').map(Number);
let a = numbers[0];
let b = numbers[1];

while (true)
        {
            if (a < b)
            {
                let temp = a;
                a = b;
                b = temp;
            }
 
            if (a % b == 0)
            {
                print(b);
                break;
            }
 
            let temp2 = b;
            b = a % b;
            a = temp2;
        }


