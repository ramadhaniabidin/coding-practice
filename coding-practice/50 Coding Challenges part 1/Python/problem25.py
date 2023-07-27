# Coding challenge #25
# Create a function that will receive 
# two arrays of numbers as arguments 
# and return an array composed of 
# all the numbers that are either 
# in the first array or second array 
# but not in both

array1 = [1, 2, 3, 10, 5, 3, 14]
array2 = [1, 4, 5, 6, 14]
# expected output = [2, 3, 10, 3, 4, 6]

def mutual_elements(arr1, arr2):
    output = []
    for i in arr1:
        found = False
        for j in arr2:
            if i == j:
                found = True
                break
        
        if found == True:
            output.append(i)
    return output

def exclusive_array(arr1, arr2):
    output = []
    mutual = mutual_elements(arr1, arr2)
    for i in mutual:
        arr1.remove(i)
        arr2.remove(i)
    
    for i in arr1:
        output.append(i)
    
    for i in arr2:
        output.append(i)
    
    return output

mutual = mutual_elements(array1, array2)
exclusive = exclusive_array(array1, array2)

print(f'The mutual elements of both arrays are: {mutual}')
print(f'The exclusive array is: {exclusive}')