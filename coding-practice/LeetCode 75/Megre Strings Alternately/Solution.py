class Solution:
    def __init__(self, word1, word2):
        self.word1 = word1
        self.word2 = word2

    def mergeAlternately(self):
        output = ''
        i = 0
        while i < len(self.word1) or i < len(self.word2):
            if i < len(self.word1):
                output += self.word1[i]
            if i < len(self.word2):
                output += self.word2[i]
            i += 1
        return output
    
class ChatGPTSolution:
    def __init__(self, word1, word2):
        self.word1 = word1
        self.word2 = word2

    def mergeAlternately(self):
        output = ''
        i = 0
        min_length = min(len(word1), len(word2))
        for i in range(min_length):
            output += word1[i] + word2[i]
        
        output += word1[min_length:] + word2[min_length:]
        return output
    
word1 = 'abcd'
word2 = 'pq'
MySolution = Solution(word1, word2)
Cheat = ChatGPTSolution(word1, word2)
print(MySolution.mergeAlternately())
print(Cheat.mergeAlternately())