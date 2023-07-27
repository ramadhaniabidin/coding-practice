# Coding challenge 24 : Create a function that will merge two arrays and return the result as a new array
array1 = [1, 2, 3]
array2 = [4, 5, 6]

def mergeArray(arr1, arr2):
    newArray = []
    for i in range(len(arr1)):
        newArray.append(arr1[i])

    for j in range(len(arr2)):
        newArray.append(arr2[j])
    return newArray

newArray = mergeArray(array1, array2)
print(f'The original arrays are {array1} and {array2}')
print(f'The merged array is: {newArray}')