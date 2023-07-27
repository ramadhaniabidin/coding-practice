/*Coding challenge #15: Create a function that will find the 
  nth Fibonacci number using recursion. */

function fibonacci(n_fibonacci){
    if(n_fibonacci==0){
        return 0;
    }
    else if(n_fibonacci==1){
        return 1;
    }
    return((fibonacci(n_fibonacci-1) + fibonacci(n_fibonacci-2)));
}
var n = 10;
var number = fibonacci(n-1);
document.write("The"+n+"th Fibonacci number is "+number);