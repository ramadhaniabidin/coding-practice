// Coding challenge #19: Create a function that will return in an array the first"nPrimes" prime numbers greater than a number "startAt"
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

function array_prime(nPrimes, startAt){
    var output = [];
    var j = 0;
    for(var i=0; i<nPrimes;){
        if((is_prime(j)==true) && (j>startAt)){
            output[i] = j;
            i++;
        }
        j++;
    }
    return output;
}

var nPrimes=100, startAt=5;
var primes = array_prime(nPrimes, startAt);
for(var i=0; i<nPrimes; i++){
    document.write(primes[i]+'<br>');
}