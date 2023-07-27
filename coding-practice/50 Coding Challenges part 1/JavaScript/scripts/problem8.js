// Coding challenge #7: Create a function that will convert from Celsius to Fahrenheit
function celsius_to_fahrenheit(celsius){
    fahrenheit = (celsius*(9/5)) + 32;
    return fahrenheit;
}

celsius = 33;
fahrenheit = celsius_to_fahrenheit(celsius);
document.write("Fahrenheit conversion of "+celsius+" Celsius is "+fahrenheit+" Fahrenheit");