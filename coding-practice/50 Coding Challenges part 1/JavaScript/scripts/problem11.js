// Coding challenge #11: Calculate the average of the numbers in an array of numbers
function average_array(input_array) {
    var sum = 0, average;
    for(var i=0; i<input_array.length; i++){
        sum += input_array[i];
    }
    average = sum/input_array.length;
    return average;
}

var array = [1, 3, 9, 15, 90];
var average = average_array(array);
document.write("The average of ["+array.join(', ')+'] is: '+average);