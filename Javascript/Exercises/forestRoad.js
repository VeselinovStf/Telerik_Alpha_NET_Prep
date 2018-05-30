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
    '5'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const size = +gets();

//upper part
for (var i = 0; i < size; i+=1) {
    print(new_string('.',i) + "*" + new_string('.', size - 1 - i));
};

//bottom part
for (var i = size -1; i > 0; i-=1) {
    print(new_string('.',i-1) + "*" + new_string('.', size- i));
};

function new_string(sign, rep){
    let output = ''
    for (var i = 0; i < rep; i+=1) {
        output+= sign;
    };

    return output;
}

const size = 