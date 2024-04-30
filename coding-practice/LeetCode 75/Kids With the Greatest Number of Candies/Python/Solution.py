class Solution:
    def __init__(self) -> None:
        pass
    def kidsWithCandies(self, candies, extraCandies):
        return [(extraCandies + i) >= max(candies) for i in candies]
    
my_solution = Solution()
candies = [2,3,5,1,3]
extra = 3
output = my_solution.kidsWithCandies(candies, extra)
print(output)