#include <vector>
#include <iostream>
using namespace std;

class Solution
{
private:
    /* data */
public:
	// This is the constructor for the class
	Solution(string a){
		
	}
	
	int sumArray(vector<int>& nums){
		int sum = 0;
		for (int num = 0; num < nums.size(); num++){
		//	cout << nums[num] <<" ";
			sum += nums[num];
		}
		//cout<<endl;
		return sum;
	}
	
	void sum1(int arr[]){
		for (int i = 0; i < sizeof(arr); i++){
			cout << arr[i] <<" ";
		}
		cout<<endl;
	}
	
	
    int findPivotIndex(vector<int>& nums){
    	int totalSum = sumArray(nums);
    	int left = 0;
    	for (int i = 0; i < nums.size(); i++){
    		int right = totalSum - left - nums[i];
    		if (left == right){
    			return i;
			}
			left += nums[i];
		}
		return -1;
	}
};

int main(){
	Solution sol("a");
	//vector<int> vec = {1, 2, 3, 4, 5, 6, 7, 8};
	int arr[] = {1,7,3,6,5,6};
	vector<int> vec(arr, arr + sizeof(arr) / sizeof(int));
	
	cout << "Pivot index of {";
	for (int i = 0; i < vec.size(); i++){
		cout << vec[i];
		if (i != vec.size() - 1){
			cout<<", ";
		}
	}
	cout << "} is: " << sol.findPivotIndex(vec);
	
	return 0;
}
