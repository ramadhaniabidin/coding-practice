nums = [1,7,3,6,5,6]

class Solution:
    def __init__(self) -> None:
        pass

    def pivotIndex(self, nums):
        totalSum = sum(nums)
        left = 0
        for i in range(len(nums)):
            right = totalSum - left - nums[i]
            if left == right:
                return i
            left += nums[i]
        return -1
    
sol = Solution()
print(f'Pivot Index: {sol.pivotIndex(nums)}')