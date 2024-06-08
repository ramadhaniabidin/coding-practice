asteroids = [10,2,-5]

class MySolution:
    def __init__(self) -> None:
        pass


    def asteroidCollision(self, asteroids):

        output = []
        left, right = 0, 1
        while right < len(asteroids):
            if asteroids[left] > 0 and asteroids[right] > 0:
                output.append(asteroids[left])
            else:
                if abs(asteroids[left]) > abs(asteroids[right]):
                    output.append(asteroids[left])
                elif abs(asteroids[left]) < abs(asteroids[right]):
                    output.append(asteroids[right])
                

            left += 1
            right += 1

        has_negative = any(o < 0 for o in output)
        if has_negative:

            output1 = []
            l, r = 0, 1
            while r < len(output):
                if output[l] > 0 and output[r] > 0:
                    output1.append(output[l])
                else:
                    if abs(output[l]) > abs(output[r]):
                        output1.append(output[l])
                    elif abs(output[l]) < abs(output[r]):
                        output1.append(output[r])
                l += 1
                r += 1

            return (output1)
        
        return(output)
    
class ChatGPTSolution:
    def __init__(self) -> None:
        pass

    def asteroidCollision(self, asteroids):
        stack = []
        for asteroid in asteroids:
            while stack and asteroid < 0 < stack[-1]:
                
                if stack[-1] < -asteroid:
                    stack.pop()
                    continue
                elif stack[-1] == -asteroid:
                    stack.pop()
                break
            else:
                stack.append(asteroid)
            print(f'Current asteroid: {asteroid}, stack: {stack}')
            
        return stack

obj = MySolution()
cheat = ChatGPTSolution()
print(f'asteroids after collision: {obj.asteroidCollision(asteroids)}')
print(f'asteroids after collision: {cheat.asteroidCollision(asteroids)}')