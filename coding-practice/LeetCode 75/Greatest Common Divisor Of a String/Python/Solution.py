class Solution:
    def __init__(self, str1, str2):
        self.str1 = str1
        self.str2 = str2
    
    def greatest_common_divisor(self):
        var1 = self.str1 + self.str2
        var2 = self.str2 + self.str1
        output = ''
        if var1 == var2:
            num1 = len(self.str1)
            num2 = len(self.str2)
            num1_factor = []
            num2_factor = []
            common_divisor = []
            divider = 1

            while divider <= num1:
                if num1 % divider == 0:
                    num1_factor.append(divider)
                divider += 1

            divider = 1
            while divider <= num2:
                if num2 % divider == 0:
                    num2_factor.append(divider)
                divider += 1
            

            for i in num2_factor:
                if i in num1_factor:
                    common_divisor.append(i)

            greatest_divisor = max(common_divisor)

            for i in range(greatest_divisor):
                output += var1[i]
            
        else:
            output = ''
        return output


class ChatGPTSolution:
    def __init__(self, str1, str2):
        self.str1 = str1
        self.str2 = str2

    def gcd(self, a, b):
        while b:
            a, b = b, a % b
        return a
    
    def gcdOfStrings(self):
        if self.str1 + self.str2 != self.str2 + self.str1:
            return ''
        len1, len2 = len(self.str1), len(self.str2)
        gcd_len = self.gcd(a=len1, b=len2)
        return self.str1[:gcd_len]

str1 = 'ABCABC'
str2 = 'ABC'
solution = Solution(str1, str2)
chatgpt_solution = ChatGPTSolution(str1, str2)
common_divisor = chatgpt_solution.gcdOfStrings()
print(common_divisor)
    