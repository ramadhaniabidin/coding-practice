# create a function that will find the n-th Fibonacci number using recursion
def find_fibonacci(x):
    if x==0:
        return 0
    elif x==1:
        return 1
    return find_fibonacci(x-1) + find_fibonacci(x-2)


print(find_fibonacci(9))