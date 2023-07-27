# Coding challenge #26
# Create a function that will receive
# two arrays and will return an array
# with elements that are in the first
# array but not in the second

array1 = [1, 2, 3, 10, 5, 3, 14]
array2 = [1, 4, 5, 6, 14]

def mutual_elements(arr1, arr2):
    output = []

    for i in arr1:
        found = False
        for j in arr2:
            if i == j:
                found = True
                break
                
        if found:
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


def remove_mutuals(arr1, arr2, array_to_keep='array1'):
    mutuals = mutual_elements(arr1, arr2)
    for i in mutuals:
        arr1.remove(i)
        arr2.remove(i)
    
    if array_to_keep == 'array1':
        output = arr1
    elif array_to_keep == 'array2':
        output = arr2
    else:
        print('Keyword error!!')
    return output

left_array = remove_mutuals(array1, array2)
right_array = remove_mutuals(array1, array2, 'array2')
print(left_array)
print(right_array)