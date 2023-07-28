// Coding challenge #22
// Reverse an array
function reverseArray(arr){
    var output = [];
    for(var i=arr.length-1; i>=0; i--){
        output.push(arr[i]);
    }

    return output;
}

var ar = [1, 2, 3];
var ar2 = reverseArray(ar);
console.log(ar2);