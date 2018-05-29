const input = gets().split(' ').map(String);

let numberReverse = input[0].split("").reverse().map(Number).join("");
const k = input[1];

let div = Math.floor(numberReverse / k);
let left = numberReverse % k;

print(div + left);


