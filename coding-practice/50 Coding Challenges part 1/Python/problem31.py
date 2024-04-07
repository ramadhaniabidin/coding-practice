# Coding challenge #31: Create a function 
# that will return the number of words in a text

class Solution:
    def __init__(self) -> None:
        pass

    def isSeparator(self, character):
        separators = [" ", "\t", "\n", "\r", ",", ";", ".", "!", "?"]
        return character in separators
    
    def countWords(self, text):
        wasSeparator = True
        words = 0

        for char in text:
            # if current character is separator then advance and
            # set the previous character was separator
            if self.isSeparator(char):
                wasSeparator = True
                continue

            # if current character is not separator
            # but if previous was separator
            if wasSeparator:
                words += 1
                wasSeparator = False
        return words
    
solutionObject = Solution()
texts = ["", "      ", "Javascript!!!   ", "    Javascript", "  Javascript is cool  ", "I like to learn javascript with codeguppy"]
for text in texts:
    print(f'The number of words in "{text}" is {solutionObject.countWords(text)}')