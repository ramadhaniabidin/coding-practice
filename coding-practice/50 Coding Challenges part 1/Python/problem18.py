# print the first 100 prime numbers
import math
def is_prime(x):
    if x < 2:
        return False
    elif x == 2:
        return True
    for i in range(2, int(math.sqrt(x) + 1)):
        if x%i == 0:
            return False
    return True

def print_prime(n_primes):
    n = 0
    i = 2
    output = []
    while(n < n_primes):
        if is_prime(i):
            output.append(i) if is_prime(i) == True else None
            n += 1
        i += 1
    return output

output = print_prime(100)
print(len(output))
print(output)
