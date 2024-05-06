nums = [1, 3, 2, 7, 5]

def max_right(nums, index):
    # this is for generating the maximum value of the remaining list
    new_nums = [nums[i] for i in range(len(nums)) if i > index]
    if len(new_nums) != 0:
        return max(new_nums)
    else:
        return 0
    
def max_overall(nums, index):
    new_nums = [nums[i] for i in range(len(nums)) if i >= index]
    if len(new_nums) != 0:
        return max(new_nums)
    else:
        return 0
    
def bigger_value_index(nums, index):
    bigger_index_list = []
    for i in range(len(nums)):
        if index != len(nums) - 1 and nums[i] > nums[index] and i > index:
            bigger_index_list.append(i)
        elif index == len(nums) - 1 and nums[i] > nums[i - 1]:
            bigger_index_list.append('kosong')
    return bigger_index_list
            

def triplet(nums):
    my_dict = {}
    for i in range(len(nums)):
        my_dict[i] = bigger_value_index(nums, i)
    print(my_dict)
    # helper = []
    # for i in range(len(nums)):
    #     if i != len(nums) - 1:
    #         if nums[i] < nums[i + 1]:
    #             helper.append(i)
    #     elif i == len(nums) - 1 and nums[i] > nums[i - 1]:
    #         helper.append(i)
    # print(helper)

triplet(nums)