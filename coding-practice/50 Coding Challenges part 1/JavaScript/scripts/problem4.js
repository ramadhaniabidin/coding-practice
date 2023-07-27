// document.write('hello &nbsp; world');
for(i=1; i<=10; i++){
    for(j=1; j<=10; j++){
        document.write(j+' x '+i+' = '+(j*i)+'&nbsp;&nbsp;&nbsp;');
        if(j%10 == 0){
            document.write('<br>');
        }
    }
}