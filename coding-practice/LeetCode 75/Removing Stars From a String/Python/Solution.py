s = "leet**cod*e"

class Solution:
    def __init__(self) -> None:
        pass

    def removeStars(self, s):
        stack = []
        for c in s:
            if c != "*":
                stack.append(c)
            else:
                stack.pop()
        return ''.join(stack)


obj = Solution()
print(f'Output string after removing \'*\' from \'{s}\' is \'{obj.removeStars(s)}\'')