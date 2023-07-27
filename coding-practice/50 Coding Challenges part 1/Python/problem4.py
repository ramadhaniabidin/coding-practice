# print all the multiplication tables with numbers from 1 to 10
for i in range(10):
    for j in range(10):
        print('{} x {} = {}'.format((i+1), (j+1), ((i+1)*(j+1))))
        print('') if (j+1)%10 == 0 else None