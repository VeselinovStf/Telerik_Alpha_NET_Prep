function findOccurrencess([word, searchLetter]) {
    let occurrencess = 0;
    for (let i = 0; i < word.length; i += 1) {
        if (word[i] == searchLetter) {
            occurrencess++;
        }
    };

    console.log(occurrencess);
}

