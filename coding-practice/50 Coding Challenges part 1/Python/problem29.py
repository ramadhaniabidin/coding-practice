# Coding challenge #29: Print the distance between the first 100 prime numbers
import math
class BookSolution:
    def __init__(self) -> None:
        pass

    def isPrime(self, number):
        if number < 2:
            return False
        elif number == 2:
            return True
        maxDiv = int(math.sqrt(number) + 1)
        for i in range(2, maxDiv):
            if number % i == 0:
                return False
        return True
    
    def printDistances(self, num_of_instances):
        lastPrime = 2
        i = lastPrime + 1
        foundPrimes = 1

        while(foundPrimes < num_of_instances):
            if(self.isPrime(i)):
                print(f'{i - lastPrime}\t {i} - {lastPrime}')
                foundPrimes += 1
                lastPrime = i
            i += 1

bookObject = BookSolution()
bookObject.printDistances(100)
