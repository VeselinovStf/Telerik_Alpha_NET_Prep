'use strict'

function demoVariables() {
    var number = typeof 5;
    var decimal = typeof 6.3;
    var string = typeof 'String is my name';
    var object = typeof {};
    var array = typeof [];
    var undifined = typeof undefined;
    var booleanVal = typeof true;
    var functionVal = typeof function () { };

    var data = [number, decimal, string, object, array, undifined, booleanVal, functionVal];
    displayVariables(data);
};

function displayVariables(data) {
    for (var i = 0; i < data.length; i += 1) {
        document.write(data[i] + "</br>");
    };
};