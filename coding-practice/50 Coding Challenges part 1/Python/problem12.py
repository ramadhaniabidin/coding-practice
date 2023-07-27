# create a function that receives an array of numbers and returns an array containing only the positive numbers
def get_positives(array):
    for element in array:
        array.remove(element) if element < 0 else array
    return array

array = [-5, 10, -3, 12, -9, 5, 90, 0, 1]
print(get_positives(array))