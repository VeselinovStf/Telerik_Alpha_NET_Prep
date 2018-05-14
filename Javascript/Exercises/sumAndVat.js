//Write a JS function that sums a variable number of prices and calculates their VAT (Value Add Tax, 20%).
const vatProcentage = 0.20;

function calculate(args) {
    let sum = calcSum(args);
    let vat = calcVat(sum, vatProcentage);
    let total = sum + vat;

    return [sum, vat, total];
};

function calcSum(args) {
    let sum = 0;
    for (var i = 0; i < args.length; i++) {
        sum += Number(args[i]);
    }; 
    return sum;
};

function calcVat(sum, vatProcentage) {
    return sum * vatProcentage;
};

function printResult(args) {
    console.log("sum = " + args[0]);
    console.log("VAT = " + args[1]);
    console.log("total = " + args[2]);
};

printResult(calculate([1.2, 2.60, 3.50]));
printResult(calculate([3.12, 5, 18, 19.24, 1953.2262, 0.001564, 1.1445]));
