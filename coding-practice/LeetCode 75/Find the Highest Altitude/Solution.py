gain = [-4,-3,-2,-1,4,3,2]

class Solution:
    def __init__(self) -> None:
        pass

    def largestAltitude(self, gain):
        for i in range(len(gain)):
            substractor = gain[i - 1]
            if i > 0:
                gain[i] += substractor
        print(f'Max altitude: {max(0, max(gain))}')
        print(gain)

sol = Solution()
sol.largestAltitude(gain)