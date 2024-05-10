nums = [1, 2, 3, 4]
k = 5
# nums.pop(1)
# print(nums)
def maxOperations(nums, k):
    nums.sort()
    left = 0
    right = len(nums) - 1
    operations = 0

    while left < right:
        if nums[left] + nums[right] == k:
            operations += 1
            left += 1
            right -= 1

        elif nums[left] + nums[right] < k:
            left += 1

        else:
            right -= 1

    print(operations)
    

maxOperations(nums, k)

