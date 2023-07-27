// Coding challenge #17: #18: Print the first 100 prime numbers
function is_prime(n){
    if(n<2){
        return false;
    }
    
    else if(n==2){
        return true;
    }

    var max_div = Math.floor(Math.sqrt(n));
    for(var i=2; i<=max_div; i++){
        if(n%i == 0){
            return false;
        }
    }
    return true;
}

var j = 0;
for(var i=1; i<=100;){
    if (is_prime(j) == true){
        document.write(j+'<br>');
        i++;
    }
    j++;
}