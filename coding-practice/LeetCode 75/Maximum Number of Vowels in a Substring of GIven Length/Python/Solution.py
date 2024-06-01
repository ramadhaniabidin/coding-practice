import time
def measure_time(func):
    def wrapper(*args, **kwargs):
        start_time = time.time()
        result = func(*args, **kwargs)
        end_time = time.time()
        print(f"Time taken to run '{func.__name__} function from Solution class': {end_time - start_time} seconds")
        return result
    return wrapper

def measure_time1(func):
    def wrapper(*args, **kwargs):
        start_time = time.time()
        result = func(*args, **kwargs)
        end_time = time.time()
        print(f"Time taken to run '{func.__name__} function from ChatGPTSolution class': {end_time - start_time} seconds")
        return result
    return wrapper

class ChatGPTSolution:
    def __init__(self) -> None:
        pass

    def numVowels(self, s):
        vowels = {'a', 'i', 'u', 'e', 'o'}
        return sum(1 for char in s if char in vowels)
    
    @measure_time1
    def maxVowels(self, s, k):
        vowels = {'a', 'i', 'u', 'e', 'o'}
        max_vowels = current_vowels = sum(1 for char in s[:k] if char in vowels)

        for i in range(k, len(s)):
            if s[i - k] in vowels:
                current_vowels -= 1
            if s[i] in vowels:
                current_vowels += 1
            max_vowels = max(max_vowels, current_vowels)
            # print(f'current index: {i}, current string: {s[:i]}, s[i]: {s[i]}, s[i - k]: {s[i - k]}, current vowels: {current_vowels}, max vowels: {max_vowels}')
        return max_vowels

class Solution:
    def __init__(self) -> None:
        pass
    
    def numVowels(self, s):
        vowels = ['a', 'i', 'u', 'e', 'o']
        num = 0
        for char in s:
            if char in vowels:
                num += 1
        return num
    
    @measure_time
    def maxVowels(self, s, k):
        substrings = {s[i: k + i]: self.numVowels(s[i: k + i]) for i in range(len(s) - k + 1)}
        return max(substrings.values())
    

s = "abciiidef"
k = 3
cheat = ChatGPTSolution()
myObj = Solution()
print(f'Solution from ChatGPT: {cheat.maxVowels(s, k)}')
print(f'My own solution: {myObj.maxVowels(s, k)}')
print(1.7881393432617188e-05 < 1.0251998901367188e-05)