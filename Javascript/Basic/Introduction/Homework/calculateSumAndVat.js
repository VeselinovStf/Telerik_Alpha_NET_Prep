function calculate(params) {
    let sum = 0;
    for (let num of params) {
        sum += Number(num);
    }

    console.log("sum = " + sum);
    console.log("VAT = " + sum * 20 / 100);
    console.log("total = " + sum * 1.20);

}
