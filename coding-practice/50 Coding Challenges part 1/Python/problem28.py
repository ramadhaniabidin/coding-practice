# Coding challenge #28: Calculate the sum of first 100 prime numbers
import math

def isPrime(number):
    if(number < 2):
        return False
    elif(number == 2):
        return True
    maxDiv = int(math.sqrt(number) + 1)
    for i in range(2, maxDiv):
        if number % i == 0:
            return False
    return True

def sumPrimeArray(num_of_elements):
    primeSum = 0
    n = 0
    i = 2
    while(n < num_of_elements):
        if(isPrime(i)):
            primeSum += i
            n += 1
        i += 1
    return primeSum

print(f'{sumPrimeArray(100)}')