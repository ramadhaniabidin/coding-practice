# rotate an array to the left 1 position
def rotate_array(array):
    output = []
    output.append(array[-1])
    array.remove(array[-1])

    for element in array:
        output.append(element)
    
    return output


array = [1, 2, 3, 4, 5]
rotated_array = rotate_array(array)
print(rotated_array)