from functools import reduce
class Arrays:
    def __init__(self) -> None:
        pass

    def HelloWorld(self):
        print("Hello")

    def SumList(self):
        myList = [1, 2, 3, 4]
        print((myList[-1]))

     # This is my answer
    def ProductList(self, nums):
        myList = [1, 2, 3, 4]
        calculatedValue = 1
        returnedList = []
        for i in nums:
            for j in nums:
                if(i != j):
                    calculatedValue *= j
            returnedList.append(calculatedValue)
            calculatedValue = 1
        return returnedList
        # print(returnedList)

    ## This is the answer from the book
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
            print(f'i = {i}')
            if i == 0:
                result.append(suffix_products[i + 1])
            elif i == len(nums) - 1:
                result.append(prefix_products[i - 1])
            else:
                result.append(prefix_products[i - 1] * suffix_products[i + 1])
            
        # print(f'Prefix products = {prefix_products}')
        # print(f'Suffix products = ', suffix_products)
        # print(result)
        return result
    
nums = [1, 2, 3, 4, 5]
myObject = Arrays()

myAnswer = myObject.ProductList(nums)
bookAnswer = myObject.products([1, 2, 3, 4, 5])

print(f'My Answer: {myAnswer}')
print(f'Book\'s Answer: {bookAnswer}')