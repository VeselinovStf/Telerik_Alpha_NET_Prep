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
    '15'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;


const size = +gets();

//upper part
let result = "";
print(new_string('.',size) + new_string('*', size));

//midle part
for (var i = 0; i < size-1; i+=1) {
    print(new_string('.', size -1 - i)+ "*" + new_string('.', (size - 1)+ i) + '*')
};

//bottom part
print(new_string('*', size * 2));

function new_string(sign, rep){
    let output = ''
    for (var i = 0; i < rep; i+=1) {
        output+= sign;
    };

    return output;
}
