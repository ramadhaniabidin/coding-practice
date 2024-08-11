roman_values = {'I': 1, 'V': 5, 'X': 10, 'L': 50, 'C': 100, 'D': 500, 'M': 1000}

class Solution:
    def __init__(self) -> None:
        pass

    def myRomanToInt(self, s):
        total = 0
        for i in range(len(s)):
            current_value = roman_values[s[i]]
            if i + 1 == len(s):
                total += current_value        
            elif s[i] == 'I' and (s[i + 1] == 'V' or s[i + 1] == 'X'):
                total -= 1
            elif s[i] == 'X' and (s[i + 1] == 'L' or s[i + 1] == 'C'):
                total -= 10
            elif s[i] == 'C' and (s[i + 1] == 'D' or s[i + 1] == 'M'):
                total -= 100
            else:
                total += current_value
        return total
    
class ChatGPTSolution:
    def __init__(self) -> None:
        pass

    def romanToInt(self, s):
        total = 0
        prev_value = 0

        for char in reversed(s):
            current_value = roman_values[char]

            if current_value < prev_value:
                total -= current_value
            else:
                total += current_value
            
            prev_value = current_value
        return total



s = 'MCMXCIV'
obj = ChatGPTSolution()
myObj = Solution()
romanInt = obj.romanToInt(s)
n = myObj.myRomanToInt(s)
print(romanInt, n)