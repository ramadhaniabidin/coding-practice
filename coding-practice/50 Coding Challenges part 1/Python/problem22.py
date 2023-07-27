# Coding challenge 22 : Reverse an array
array = [1, 2, 3, 4, 5]
newArray = []

for i in range(len(array), 0, -1):
    newArray.append(array[i - 1])

print(newArray)
