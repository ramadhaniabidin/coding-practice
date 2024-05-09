class Solution:
    def __init__(self) -> None:
        pass
    def isSubsequence(self, s: str, t: str) -> bool:
        if len(s) == 0:
            return True
        
        s_index = 0
        for char in t:
            if char == s[s_index]:
                s_index += 1
                if s_index == len(s):
                    return True
        return False
    
solution = Solution()
print(solution.isSubsequence('acb', "ahbgdc"))