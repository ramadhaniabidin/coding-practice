class Solution:
    def __init__(self) -> None:
        pass

    def reverseVowels(self, s):
        vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'I', 'U', 'E', 'O']
        vowel_pos = [i for i in range(len(s)) if s[i] in vowels]
        vowel_pos.reverse()
        idx = 0
        output = ''

        for i in s:
            if i not in vowels:
                output += i
            else:
                output += s[vowel_pos[idx]]
                idx +=1
        return output
    
sol = Solution()
s = 'Avaa'
print(sol.reverseVowels(s))