# include <iostream>
# include <vector>
using namespace std;

class Solution{
	private:
	
	public:
		int longestOnes(vector<int>& nums, int k){
			int left = 0;
			int max_ones = 0;
			int zeros_count = 0;
			
			for(int right = 0; right < nums.size(); right++){
				if(nums[right] == 0){
					zeros_count += 1;
				}
				
				if(zeros_count > k){
					if(nums[left] == 0){
						zeros_count -= 1;
					}
					left += 1;
				}
				
				max_ones = max(max_ones, (right - left + 1));
			}
			return max_ones;
		};
};

int main(){
	Solution sol;
	int arr[] = {0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1};
	int k = 3;
	vector<int> nums(arr, arr + sizeof(arr) / sizeof(int));
	
	cout << k << " longest ones of {";
	for(int i = 0; i < nums.size(); i++){
		cout << nums[i];
		if(i != nums.size() - 1){
			cout << ", ";
		}
	}
	cout << "} is " << sol.longestOnes(nums, k);
};
