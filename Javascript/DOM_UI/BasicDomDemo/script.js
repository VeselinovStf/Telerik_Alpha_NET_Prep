let element = document.getElementById('text');

element.innerText ='Some text here!';
element.style.color = 'red';

function makeItBig(){
    element.style.fontSize = '50px';
    setTimeout(makeItSmall,1000);
}

function makeItSmall(){
    element.style.fontSize = '10px';
    setTimeout(makeItBig, 1000);
}

makeItBig();