nums1 = [1,2,3,3]
nums2 = [1,1,2,2]


class MySolution:
    def __init__(self) -> None:
        pass

    def findDifference(self, nums1, nums2):
        ans = [[i for i in (set(nums1)) if i not in nums2], [j for j in (set(nums2)) if j not in nums1]]
        return ans
    
class ChatGPTSolution:
    def __init__(self) -> None:
        pass

    def findDifference(self, nums1, nums2):
        set1, set2 = set(nums1), set(nums2)
        ans = [
            list(set1 - set2),
            list(set2 - set1)
        ]
        return ans