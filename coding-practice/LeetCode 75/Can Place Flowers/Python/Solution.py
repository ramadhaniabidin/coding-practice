class Solution:
    def __init__(self) -> None:
        pass
    
    def canPlantFlowers(self, flowerbed, n):
        flowers_planted = 0
        for i in range(len(flowerbed)):
            if flowerbed[i] == 0:
                left_empty = (i == 0) or (flowerbed[i - 1] == 0)
                right_empty = (i == len(flowerbed) -1 ) or (flowerbed[i + 1] == 0)
                print(f'i: {i}, left_empty: {left_empty}, right_empty: {right_empty}')

                if left_empty and right_empty:
                    flowerbed[i] = 1
                    flowers_planted += 1
        return flowers_planted >= n
    
flowerbed = [1,0,1,0,0,1,0]
n = 1
solution = Solution()
can_plant = solution.canPlantFlowers(flowerbed, n)
print(f'Can plant flowers? : {can_plant}')