// Coding challenge #16: Create a function that will return a Boolean specifying if a number is prime
function is_prime(number){
    if(number<2){
        return false;
    }

    else if(number==2){
        return true;
    }

    var max_div = Math.floor(Math.sqrt(number));
    for(var i=2; i<=max_div; i++){
        if(number%i == 0){
            return false;
        }
    }
    return true;
}

var numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
for(var i=0; i<numbers.length; i++){
    document.write("Is "+numbers[i]+' a prime number? : '+is_prime(numbers[i])+'<br>');
}

