# Coding challenge #30b: Create a function 
# that will add two indefinite size numbers. 
# Only positive numbers will be used and will 
# be provided to the function as strings. The 
# result should be also returned as a string.

def add(number1, number2):
    return str(int(number1) + int(number2))

n1 = '123'
n2 = '34567'
sum = add(number1=n1, number2=n2)
print(f'Sum of {n1} and {n2} is = {sum}')