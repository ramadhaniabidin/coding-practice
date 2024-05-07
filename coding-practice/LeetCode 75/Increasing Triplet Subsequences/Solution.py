class Solution:
    def __init__(self) -> None:
        pass

    def increasingTripletSubsequence(self, nums):
        if len(nums) < 3:
            return False
        
        min_so_far = float('inf')
        second_min_so_far = float('inf')

        for num in nums:
            if num <= min_so_far:
                min_so_far = num
            elif num <= second_min_so_far:
                second_min_so_far = num
            else:
                return True
            
        return False
    

solution = Solution()
nums = [1, 6, 2, 5, 6]
print(solution.increasingTripletSubsequence(nums))