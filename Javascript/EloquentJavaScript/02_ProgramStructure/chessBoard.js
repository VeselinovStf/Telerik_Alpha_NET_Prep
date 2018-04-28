function generateCheseBoard(width, heigh) {
    let result = "";
    for (var i = 0; i < heigh; i++) {
        let block = "";
        if (i % 2 == 0) {
           block = " #";     
        }
        else {
           block = "# ";         
        }
        result += fillString(block, width / 2) + "\n";
    }
    return result;
}

function fillString(str, count) {
    let result = "";
    for (var i = 0; i < count; i++) {
        result += str;
    }
    return result;
}

console.log(generateCheseBoard(5,5));