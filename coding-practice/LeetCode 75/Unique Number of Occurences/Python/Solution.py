arr = [1,2,2,1,1,3,4,4,4]

class MySolution:
    def __init__(self) -> None:
        pass


    def uniqueOccurrences(self, arr):
        occurrences = list({i: arr.count(i) for i in set(arr)}.values())
        ans = True in (occurrences.count(i) > 1 for i in set(occurrences))
        return not ans
    

class ChatGPTSolution:
    def __init__(self) -> None:
        pass

    def uniqueOccurrences(self, arr):
        occurrences = {}
        for num in arr:
            if num in occurrences:
                occurrences[num] += 1
            else:
                occurrences[num] = 1
        counts = list(occurrences.values())
        return len(counts) == len(set(counts))
    


def countOccurences(arr):
    counts = {}
    n = 1
    explored_elements = []
    for i in range(len(arr)):
        if arr[i] not in explored_elements: 
            explored_elements.append(arr[i])
        # if i != 0:
            
        if i == 0: # this is the first element
            counts[arr[i]] = n
        

    print(explored_elements)


countOccurences(arr)
# ans = uniqueOccurrences(arr)
# print(ans)



