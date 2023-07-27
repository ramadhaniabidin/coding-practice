// Coding challenge #9: Create a function that will convert from Fahrenheit to Celsius
function fahrenheit_to_celsius(fahrenheit){
    var celsius = (fahrenheit-32)/1.8;
    return celsius;
}

var fahrenheit = 27.9;
var celsius = fahrenheit_to_celsius(fahrenheit);
document.write("Celsius conversion of "+fahrenheit+" Fahrenheit is "+celsius+" Celsius");