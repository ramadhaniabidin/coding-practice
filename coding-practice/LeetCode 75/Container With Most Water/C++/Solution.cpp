#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

class Solution{
    private:

    public:
    int max_element(vector<int>& height){
        int maximum = height[0]; 
        for(int i = 1; i < height.size(); i++){
            if(maximum < height[i]){
                maximum = height[i];
            }
        }

        return maximum;
    }
    
    int min_element(vector<int>& height){
        int minimum = height[0]; 
        for(int i = 1; i < height.size(); i++){
            if(minimum > height[i]){
                minimum = height[i];
            }
        }

        return minimum;
	}
	
	int min(int x, int y){
		if(x > y){
			return y;
		}
		return x;
	}
    
    
    int maxArea(vector<int>& height){
    	int left, right, max_area;
    	left = 0;
    	right = height.size() - 1;
    	max_area = 0;
    	
    	while(left < right){
    		int area = min(height[left], height[right]) * (right - left);
    		max_area = max(max_area, area);
    		
    		if(height[left] < height[right]){
    			left += 1;
			}else{
				right -= 1;
			}
		}
		return max_area;
	}
};


int main(){
    Solution obj;

    int arr[] = {1,8,6,2,5,4,8,3,7};
	vector<int> height(arr, arr + sizeof(arr) / sizeof(int));
    
	int maxArea = obj.maxArea(height);
	cout << "The max area is: " << maxArea;
    return 0;
}
