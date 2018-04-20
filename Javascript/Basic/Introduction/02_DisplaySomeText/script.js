var data = [
    "My First Display",
    "data 1",
    "Data 2",
    "Data 3",
    "Data 4",
    "Data 5"
];

var header = document.getElementsByTagName('h1');
header[0].innerText = data[0];

var ul_Lis = document.getElementsByTagName('li');
for(var i = 0; 0 < data.length; i+= 1){
    ul_Lis[i].innerText = data[i+ 1];
};