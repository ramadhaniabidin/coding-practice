// Coding challenge #17: Calculate the sum of digits of a positive integer number
function sum_digits(n){
    var sum = 0;
    while(n>0){
        var increment = (n%10);
        sum += increment;
        n = Math.floor(n/10);
    }
    return sum;
}

var digits = 12345;
var sum = sum_digits(digits);
document.write("The sum of "+digits+" is "+sum);