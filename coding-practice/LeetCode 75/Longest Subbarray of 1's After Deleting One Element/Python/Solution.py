nums = [1,1,0,1]

class Solution:
    def __init__(self) -> None:
        pass

    def longestSubarray(self, nums):
        left = zeros_count = max_len = 0
        for right in range(len(nums)):
            if nums[right] == 0:
                zeros_count += 1

            while zeros_count > 1:
                if nums[left] == 0:
                    zeros_count -= 1
                left += 1

            max_len = max(max_len, (right - left))
            print(f'left: {left}, right: {right}, subarray: {nums[left:right]}')

        if zeros_count == 0:
            return len(nums) - 1
        
        return max_len
    
obj = Solution()
print(f'Longest sub array of 1\'s of {nums} after deleting one element is : {obj.longestSubarray(nums)}')
        