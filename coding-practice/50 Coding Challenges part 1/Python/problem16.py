# create a function that will return a Boolean specifying if a number is prime
import math
def is_prime(x):
    if x<2:
        return False
    elif x==2:
        return True
    # a number is considered to be prime if the modulus of that number with its square root is not equal to zero
    # sebuah bilangan dikatakan prima jika hasil bagi antara bilangan tersebut dengan pembulatan dari akarnya 
    # tidak sama dengan nol
    for i in range(2, int(math.sqrt(x) + 1)):
        if x%i == 0:
            return False
    return True
x = int(input('insert a number '))
print("{} is prime?: {}".format(x, str(is_prime(x))))
