import time

def measure_time(func):
    def wrapper(*args, **kwargs):
        start_time = time.time()
        result = func(*args, **kwargs)
        end_time = time.time()
        print(f"Time taken to run '{func.__name__} function': {(end_time - start_time) * 1000} miliseconds")
        return result
    return wrapper


class Solution:
    def __init__(self) -> None:
        pass

    @measure_time
    def maxArea(self, height: list):
        left = 0
        right = len(height) - 1
        max_area = 0

        while left < right:
            area = min(height[left], height[right]) * (right - left)

            max_area = max(max_area, area)

            if height[left] < height[right]:
                left += 1
            else:
                right -= 1
        
        print(f'max area : {max_area}')

height = [1,8,6,2,5,4,8,3,7]
solution = Solution()
print(solution.maxArea(height))