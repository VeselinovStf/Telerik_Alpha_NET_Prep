function timeFunc() {
    var timeNow = new Date();

    var hour = timeNow.getHours();
    var minutes = timeNow.getMinutes();
    var seconds = timeNow.getSeconds();

    document.getElementById("clock").value = "" + hour + ":" + minutes + ":" + seconds;
}

setInterval(timeFunc, 1000);