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
arr = [34, -50, 42, 14, -5, 86]
myObject = MySolution()
bookObject = BookSolution()

myAnswer = myObject.products(nums)
bookAnswer = bookObject.products(nums)

# print(f'My Answer: {myAnswer}')
# print(f'Book\'s Answer: {bookAnswer}')
print(f'Maximum sub array sum: {bookObject.max_subarray_sum([8, -1, 3, 4])}')