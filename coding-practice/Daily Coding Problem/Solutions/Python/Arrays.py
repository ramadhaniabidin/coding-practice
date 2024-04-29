from functools import reduce
class MySolution:
    def __init__(self) -> None:
        pass
    def products(self, nums):
        calculatedValue = 1
        returnedList = []
        for i in nums:
            for j in nums:
                if(i != j):
                    calculatedValue *= j
            returnedList.append(calculatedValue)
            calculatedValue = 1
        return returnedList
    
class MaximumSubArraySum:
    def __init__(self, arr):
        self.array = arr

    def max_subarray_sum(self):
        max_ending_here = max_so_far = 0
        for x in self.array:
            max_ending_here = max(x, max_ending_here + x)
            max_so_far = max(max_so_far, max_ending_here)
        return max_so_far
    
    def min_subbarray_sum(self):
        min_ending_here = min_so_far = 0
        for x in self.array:
            min_ending_here = min(x, min_ending_here + x)
            min_so_far = min(min_so_far, min_ending_here)
        return min_so_far
    
    def maximum_circular_subbarray(self):
        max_subarray_sum_wraparround = sum(self.array) - self.min_subbarray_sum()
        return max(self.max_subarray_sum(), max_subarray_sum_wraparround)
        
    
class BookSolution:
    def __init__(self) -> None:
        pass
    def products(self, nums):
        # Generate prefix products.
        prefix_products = []
        for num in nums:
            if prefix_products:
                prefix_products.append(prefix_products[-1] * num)
            else:
                prefix_products.append(num)
            # print(prefix_products)
        

        # Generate suffix products.
        suffix_products = []
        for num in reversed(nums):
            if suffix_products:
                suffix_products.append(suffix_products[-1] * num)
            else:
                suffix_products.append(num)
            
        suffix_products = list(reversed(suffix_products))
        # print(f'Suffix products = {suffix_products}')


        # Generate result from the product of prefixes and suffixes
        result = []
        for i in range(len(nums)):
            if i == 0:
                result.append(suffix_products[i + 1])
            elif i == len(nums) - 1:
                result.append(prefix_products[i - 1])
            else:
                result.append(prefix_products[i - 1] * suffix_products[i + 1])
        return result
    
    def max_subarray_sum(self, arr):
        max_ending_here = max_so_far = 0
        for x in arr:
            max_ending_here = max(x, (max_ending_here + x))
            max_so_far = max(max_so_far, max_ending_here)
            # print(f'max_ending_here: {max_ending_here}')
            # print(f'max_so_far: {max_so_far}\n')
        return max_so_far

nums = [1, 2, 3, 4, 5]
arr = [8, -1, 3, 4]
myObject = MySolution()
bookObject = BookSolution()
maxSubArraySum = MaximumSubArraySum(arr)

myAnswer = myObject.products(nums)
bookAnswer = bookObject.products(nums)

# print(f'My Answer: {myAnswer}')
# print(f'Book\'s Answer: {bookAnswer}')
print(f'Maximum sub array sum: {maxSubArraySum.max_subarray_sum()}')
print(f'Maximum sub array sum wrap around: {maxSubArraySum.maximum_circular_subbarray()}')