# calculate the sum of even numbers greater than 10 and less than 30
sum = 0
for i in range(10, 30):
    if i%2 == 0:
        sum += (i-1)

print(sum)