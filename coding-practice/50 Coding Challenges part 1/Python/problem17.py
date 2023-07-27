# calculate the sum of digits of a positive integer number
def sum_digits(x):
    string = str(x)
    sum = 0
    for i in string:
        sum += int(i)
    return sum

x = input('insert a number ')
print("The sum of {} is {}".format(x, sum_digits(x)))