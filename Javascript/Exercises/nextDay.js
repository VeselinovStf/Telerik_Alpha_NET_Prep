function currentTime(year,month,day) {
    let inputTime = Date(year, month, day);

    console.log(inputTime.month);
    return inputTime;
}

function nextDay(currentDay) {
    return currentTime.currentDay;
}

var inputTime = currentTime(1999, 2, 2);
console.log(nextDay(inputTime));