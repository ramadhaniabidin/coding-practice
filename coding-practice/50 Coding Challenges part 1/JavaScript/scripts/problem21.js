// Coding challenge #21
// Rotate an array to the right 1 position
function rotateRight(arr){
    var last = arr.pop();
    arr.unshift(last);
}

var ar = [1, 2, 3];
rotateRight(ar);
console.log(ar);