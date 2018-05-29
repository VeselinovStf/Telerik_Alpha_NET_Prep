

const number = +gets();

if (number <= 0 || number > 9) {
    print("invalid score");
}
else    {
    if (number >= 1 && number <= 3) {
        print(number * 10);
    }
    else if (number >= 4 && number <= 6) {
        print(number * 100);
    }
    else    {
        print(number * 1000);
    }
}