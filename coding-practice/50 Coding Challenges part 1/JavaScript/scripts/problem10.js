// Coding challenge #10 Calculate the sum of numbers in an array of numbers.
function sum_array(input){
    var sum=0;

    for(var i=0; i<input.length; i++){
        sum += input[i];
    }
    return sum;
}

var array = [2, 3, -1, 5, 7, 9, 10, 15, 95];
var sum = sum_array(array);
document.write("The sum of every elements in [");
for(var i=0; i<array.length-1; i++){
    document.write(array[i]+", ");
}
document.write(array[array.length-1]+"] is: "+sum);