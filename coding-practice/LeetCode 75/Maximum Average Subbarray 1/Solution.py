nums = [3]
k = 1
# print(nums[:3])

def maximum_subarray_sum(nums):
    left = 0
    right = k - 1
    average = max_average = 0
    while right <= len(nums) - 1:
        average = (sum(nums[left:right + 1]) / k)
        max_average = max(max_average, average)
        print(f'Current average: {average:.5f}, Max average: {max_average:.5f}')
        left += 1
        right += 1
    return max_average
max_avg = maximum_subarray_sum(nums)
print(max_avg)
