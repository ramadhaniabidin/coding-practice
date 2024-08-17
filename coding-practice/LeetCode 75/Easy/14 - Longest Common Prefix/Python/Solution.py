strs = ["flower","flow","flight"]

class Solution:
    def __init__(self) -> None:
        pass

    def longestCommonPrefix(self, listOfStrings):
        # If the list string is empty
        if not listOfStrings:       
            return ""
        
        prefix = listOfStrings[0]
        for string in listOfStrings[1:]:
            # condition if current string does not begins with prefix
            while string[:len(prefix)] != prefix:
                # gradually remove the last element on the prefix
                prefix = prefix[:-1]
                # if prefix eventually becomes empty, then it means there are no common prefix in listOfString
                if not prefix:
                    return ""

        # return prefix
        return prefix
    
    def display_solution(self):
        loop = True

        while loop:
            print("Longest Common Prefix")
            print("This function will search for the longest common prefix of a list of strings")
            input_string = input("Enter a list of strings separated by commas: ")
            words = input_string.split(",")
            longestPrefix = self.longestCommonPrefix(words)
            print(f'Longest common prefix of {words} is \'{longestPrefix}\'')
            while True:
                print("Would you like to repeat? (y/n)")
                response = input()
                response = "" if response is None else response

                if response == "":
                    print("Please choose the option")
                elif response == "y" or response == "Y":
                    loop = True
                    break
                elif response == "n" or response == "N":
                    loop = False
                    break
                else:
                    print("Invalid input. Please enter 'y' or 'n'")

    
obj = Solution()
obj.display_solution()

