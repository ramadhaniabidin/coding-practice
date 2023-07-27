var sum_odds = 0;
for(var i=11; i<=30; i++){
    if(i%2 == 1){
        sum_odds += i;
    }
}
document.write("The sum of odd numbers greater than 10 and less or equal to 30 is: "+sum_odds);