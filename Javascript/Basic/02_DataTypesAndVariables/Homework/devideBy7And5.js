function solve(args) {
    let num = parseInt(args);
    if (args % 7 == 0 && args % 5 == 0) {
        console.log("true " + num);
    }
    else {
        console.log("false " + num)
    }
}