const numbers = gets().split(' ').map(Number);
let largest = numbers[0];

for (var i = 1; i < numbers.length; i+=1) {
    if (numbers[i] > largest) {
        largest = numbers[i];
    }
};

print(largest);