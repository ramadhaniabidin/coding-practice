class Solution:
    def __init__(self) -> None:
        pass

    def compress(self, chars=["a","a","b","b","c","c","c"]):
        curr_element = chars[0]
        n_occurr = 0
        str_compress = ""

        for i in range(len(chars)):
            if curr_element == chars[i]:
                n_occurr += 1
            else:
                # out.append(f'{curr_element}{n_occurr}')
                str_compress += f'{curr_element}{n_occurr}' if n_occurr > 1 else f'{curr_element}'
                curr_element = chars[i]
                n_occurr = 1

            if i + 1 == len(chars):
                # out.append(f'{curr_element}{n_occurr}')
                str_compress += f'{curr_element}{n_occurr}' if n_occurr > 1 else f'{curr_element}'
        print(str_compress)

        chars.clear()
        for i in str_compress:
            chars.append(i)
        return len(chars)
    
mySolution = Solution()
print(mySolution.compress())