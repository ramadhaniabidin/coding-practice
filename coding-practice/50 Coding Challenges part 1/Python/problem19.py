# create a function that will return an array of the first nPrime numbers greater than a number startAt
import math
def is_prime(x):
    if x < 2:
        return False
    if x == 2:
        return True
    for i in range(2, int(math.sqrt(x) + 1)):
        if x%i == 0:
            return False
    return True

def array_prime(n_prime, start_at):
    n = 0
    i = (start_at + 1)
    array = []

    while (n < n_prime):
        if is_prime(i):
            array.append(i) if (is_prime(i) == True and i > start_at) else None
            n += 1
        i += 1
    return array

array = array_prime(6, 11)
print(array)
