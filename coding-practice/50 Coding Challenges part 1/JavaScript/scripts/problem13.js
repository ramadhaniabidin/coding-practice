// Coding challenge #13: Find the maximum number in an array of numbers
var array = [-5, 10, -3, 4, 39, 12, -32, 9, 10];
var max = array[0];
for(var i=0; i<array.length; i++){
    if(array[i]>max){
        max = array[i];
    }
}
document.write("The maximum of ["+array.join(', ')+'] is: '+max);