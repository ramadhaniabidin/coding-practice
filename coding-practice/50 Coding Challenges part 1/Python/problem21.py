# Coding challenge 21 : Rotate an array to the right 1 position

# The initial array
array = [1, 2, 3, 4, 5]

# Create a new empty array
newArray = []

# Set the last value of the array to be the first value of the newArray
newArray.append(array[len(array) - 1])

# This looping is inserting the rest of the array's value to the newArray
for i in range(0, 4):
    newArray.append(array[i])

# print the newArray
print(newArray)