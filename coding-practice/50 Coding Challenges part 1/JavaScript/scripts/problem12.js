/* Create a function that receives an 
array of numbers and returns an
array containing only the positive
numbers. */
function positive_array(input) {
    var output = [];
    var n_positives = 0;
    for(var i=0; i<input.length; i++){
        if(input[i]>0){
            n_positives++;
        }
    }
    var j = 0;
    for(var i=0; i<n_positives;){
        if(input[j]>0){
            output[i] = input[j];
            i++;
        }
        j++;
    }
    return output;
}

var array = [-5, 10, -3, 4, 39, 12, -32, 9, 10];
var output = positive_array(array);
document.write("The only positive elements of ["+array.join(', ')+'] are: ['+output.join(', ')+']');