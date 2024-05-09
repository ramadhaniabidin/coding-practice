nums = [0,1,0,3,12]

class Solution:
    def __init__(self) -> None:
        pass

    def moveZeroes(self, nums=nums):
        zero_count = nums.count(0)
        nums[:] = [num for num in nums if num != 0] + [0] * zero_count
        return nums
    
mySolution = Solution()
shift_zeroes_num = mySolution.moveZeroes(nums)
print(shift_zeroes_num)