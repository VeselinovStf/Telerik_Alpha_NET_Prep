for (var i = 1; i <= 20; i+=1) {
    var random = Math.random();
    random = 10 * random + 1;
    random = Math.floor(random);

    document.write(
        "Random number (" + i + ") in range 1.. 10 -->" + random + "</br>"
    );
}