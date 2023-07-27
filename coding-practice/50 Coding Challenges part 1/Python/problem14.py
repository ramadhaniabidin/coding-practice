# find the first 10 Fibonacci numbers without using recursion
f0 = 0
f1 = 1

print("f0 = {}".format(f0))
print("f1 = {}".format(f1))

for i in range(2, 10):
    fi = f0 + f1
    print('f{} = {}'.format(i, fi))
    f0 = f1
    f1 = fi