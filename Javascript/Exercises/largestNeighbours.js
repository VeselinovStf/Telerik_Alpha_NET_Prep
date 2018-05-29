const size = +gets();
const array = gets().split(' ').map(Number);

let totalNeighbours = 0;
for (var i = 1; i < size -1; i+=1) {
    var currentNeighbour = array[i];
    var left = array[i-1];
    var right = array[i+1];

    if (currentNeighbour > left && currentNeighbour > right) {
        totalNeighbours++;
    }
};
print(totalNeighbours);