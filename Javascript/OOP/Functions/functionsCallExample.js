const modifier = [
    function(x){ return x * 2},
    function(x) { return x / 2},
    function(x) {return 666}
];

function applyToAll(x){
    return x(5);
}

modifier.map(applyToAll)
.forEach(x => console.log(x));

