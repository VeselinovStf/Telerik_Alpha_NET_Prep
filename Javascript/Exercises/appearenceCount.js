

const size = gets();
const array = gets().split(' ').map(Number);
const searchNumber = +gets();

let count = 0;
for (var i = 0; i < array.length; i+=1) {
    if (array[i] == searchNumber) {
        count++;
    }
};

print(count);