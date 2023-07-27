# find the maximum number in an array of numbers
def find_max(x):
    output = x[0]
    for i in x:
        output = i if i > output else output
    return output

array = [-5, 10, -3, 12, -9, 5, 10, 0, 1]
print(find_max(array))