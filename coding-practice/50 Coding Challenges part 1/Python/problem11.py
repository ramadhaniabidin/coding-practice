# calculate the average numbers of the numbers in an array of numbers
def calculate_average(array):
    sum = 0
    for element in array:
        sum += element
    average = sum / len(array)
    return average


array = [1, 3, 9, 15, 90]
print('The average numbers of that particular array is {}'.format(calculate_average(array)))