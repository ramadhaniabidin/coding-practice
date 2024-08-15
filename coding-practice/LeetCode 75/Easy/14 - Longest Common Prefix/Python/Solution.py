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
    
obj = Solution()
longestPrefix = obj.longestCommonPrefix(strs)
print(f'Longest common prefix of {strs} is \'{longestPrefix}\'')