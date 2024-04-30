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
    
word1 = 'abcd'
word2 = 'pq'
MySolution = Solution(word1, word2)
print(MySolution.mergeAlternately())