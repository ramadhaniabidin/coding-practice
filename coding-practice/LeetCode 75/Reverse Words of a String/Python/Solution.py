class Solution:
    def __init__(self) -> None:
        pass

    def reverseWord(self, s):
        s += " "
        word, words = '', []
        for i in range(len(s)):
            if s[i] != ' ':
                word += s[i]
            else:
                words.append(word)
                word = ''
        reverse_words = [i for i in words if i != '']
        reverse_words.reverse()
        reversed_word = ''
        for i in range(len(reverse_words)):
            if reverse_words[i] != '' and i != (len(reverse_words) - 1):
                reversed_word += f'{reverse_words[i]} '
            else:
                reversed_word += f'{reverse_words[i]}'
        return reversed_word
    
solution = Solution()
s = '   hello  world   '
rev = solution.reverseWord(s)
print(rev)