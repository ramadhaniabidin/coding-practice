# Coding challenge 23 : Reverse a string
myString = 'Ramadhani Abidin'
newString = ''
i = len(myString)

while(i > 0):
    newString += myString[i -1]
    i -= 1

print(f'Original string: {myString}')
print(f'Reversed string: {newString}')