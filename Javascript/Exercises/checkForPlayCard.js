
const cards = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K' , 'A'];
const input = gets();

const containsCard = Contains(cards,input);

function Contains(array, value){
    for (var i = 0; i < array.length; i+=1) {
        if (array[i] == value) {
            return true;
        }
    };
    return false;
}

if (containsCard == true) {
    print("yes " + input);
}
else{
    print("no " + input);
}