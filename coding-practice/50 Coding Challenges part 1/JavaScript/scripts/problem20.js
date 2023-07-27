// Coding challenge #20: Rotate an array to the left 1 position
function rotate_array(input_array){
    var output = [];
    output[0] = input_array[input_array.length-1];
    for(i=1; i<input_array.length; i++){
        output[i] = input_array[i-1];
    }
    return output;
}

var array = [1, 2, 3, 4, 5];
var rotated_array = rotate_array(array);
document.write('The rotated version of ['+array.join(', ')+'] is: ['+rotated_array.join(', ')+']');