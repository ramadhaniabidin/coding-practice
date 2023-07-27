// Coding challenge #14: Print the first 10 Fibonacci numbers without using recursion.
function fibonacci(n_fibonacci) {
    var f0 = 0, f1 = 1;
    var output = [];
    output[0] = f0; output[1] = f1;
    for(var i=2; i<n_fibonacci; i++){
        var fi = f1 + f0;
        output[i] = fi;
        f0 = f1;
        f1 = fi;
    }
    return output;
}

var n_fibonacci = 10
var output = fibonacci(n_fibonacci);
document.write('The first '+n_fibonacci+' Fibonacci numbers are: ['+output.join(', ')+']');