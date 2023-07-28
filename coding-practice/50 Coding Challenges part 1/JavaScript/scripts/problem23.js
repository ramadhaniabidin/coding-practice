// Coding challenge #23
// Reverse a string
function reverseString(s){
    var output = "";
    for(var i = s.length - 1; i >= 0; i--){
        var char = s[i];
        output += char;
    }

    return output;
}

var s = reverseString("JavaScript");
console.log(s);