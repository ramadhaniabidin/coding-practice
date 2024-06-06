nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1]
k = 3

class Solution:
    def __init__(self, nums, k) -> None:
        self.nums = nums
        self.k = k

    def longestOnes(self):
        left = max_ones = zeros_count = 0
        for right in range(len(self.nums)):
            if self.nums[right] == 0:
                zeros_count += 1
            
            if zeros_count > self.k:
                if self.nums[left] == 0:
                    zeros_count -= 1
                left += 1
            max_ones = max(max_ones, (right - left + 1))
        return max_ones
    
obj = Solution(nums, k)
longestOnes = obj.longestOnes()
print(f'{k} longest ones of {nums} is : {longestOnes}')