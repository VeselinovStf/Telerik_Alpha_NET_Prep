

const size = gets();
const arr = gets().split(" ").map(Number);

let eavenProduct = arr[1];
let oddProduct = arr[0];

for (var i = 2; i < arr.length; i+=1) {
    if (i % 2 != 0) {
        eavenProduct *= arr[i]
    }
    else{
        oddProduct *= arr[i]
    }
};

if (oddProduct == eavenProduct) {
    print("yes " + eavenProduct)
}
else{
    print("no " + oddProduct + " " + eavenProduct);
}