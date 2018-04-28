function countBs(str, char = "B") {
    let count = 0;
    for (var i = 0; i < str.length; i++) {
        if (str[i] == char) {
            count++;
        }
    }
  
    return count;
}

function countChar(str, char) {
    return countBs(str, char);
}

console.log(countBs("BBC"));
// → 2
console.log(countChar("kakkerlak", "k"));
// → 4