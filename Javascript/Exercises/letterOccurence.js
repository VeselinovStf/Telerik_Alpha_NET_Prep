//Write a JS function that counts how many times a specific letter occurs in a given string.

function countLetterOccurence(...args) {
    let occurencess = 0;
    let word = args[0];
    for (var i = 0; i < word.length; i++) {
        if (word[i] == args[1]) {
            occurencess++;
        }
    }
    return occurencess;
}

console.log(countLetterOccurence('hello', 'l'));
console.log(countLetterOccurence('panther', 'n'));