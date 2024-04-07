class Solution:
    def __init__(self) -> None:
        pass

    def isSeparator(self, character):
        separators = [" ", "\t", "\n", "\r", ",", ";", ".", "!", "?"]
        return character in separators
    
    def text_length(self, text):
        length = 0
        length_list = []
        last_char_index = len(text)
        for character in text:
            if self.isSeparator(character):
                length_list.append(length)
                length = 0
            else:
                length += 1
                if character == text[last_char_index - 1]:
                    length_list.append(length)
        print(length_list)

    
    def splitText(self, text):
        word = ""
        split_text = []
        last_char_index = len(text)

        for char in text:
            if self.isSeparator(character=char):
                split_text.append(word)
                word = ""
            else:
                word += char
                if char == text[last_char_index - 1]:
                    split_text.append(word)

        return split_text
    
    def capitalize_text(self, text):
        split_text = self.splitText(text)
        capital_text = ""
        for t in split_text:
            capital_text += t.capitalize() + " "
        print(capital_text)

    def capitalize_text_1(self, text):
        capital_text = ""
        for t in text.split(" "):
            capital_text += t.capitalize() + " "
        print(capital_text)
    
obj = Solution()
text = "I like to learn javascript with codeguppy"
obj.capitalize_text(text)
obj.capitalize_text_1(text)