# Coding challenge #27a
# Create a function that will receive an array of 
# numbers as argument and will return a new 
# array with distinct elements

def isInArray(num, array):
    return num in array

# this is my solution
def getDistinctArray(array):
    distinctArray = []
    for i in array:
        if not (isInArray(num=i, array=distinctArray)):
            distinctArray.append(i)    
    return distinctArray

# this is the solution from chat gpt
def chatGPTSolution(array):
    return list(set(array))

arr = [1, 2, 3, -1, 2]
distincArray = getDistinctArray(array=arr)
print(f'Distinc Array of {arr} is : {distincArray}')
