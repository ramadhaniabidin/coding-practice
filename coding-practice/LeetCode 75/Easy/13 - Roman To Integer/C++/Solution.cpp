#include<iostream>
#include<vector>
#include<map>

using namespace std;

class Solution{
	private:
		map<char, int> romanValues;	
	
	public:	
	Solution(){
		romanValues.insert(make_pair('I', 1));
	    romanValues.insert(make_pair('V', 5));
	    romanValues.insert(make_pair('X', 10));
	    romanValues.insert(make_pair('L', 50));
	    romanValues.insert(make_pair('C', 100));
	    romanValues.insert(make_pair('D', 500));
	    romanValues.insert(make_pair('M', 1000));
	}
    
    int romanToInt(string nums){
    	int total = 0;
    	for(int i = 0; i < nums.size(); i++){
    		int current_value = romanValues[nums[i]];
    		if(i + 1 == nums.size()){
    			total += current_value;
			}
			else if(nums[i] == 'I' and (nums[i + 1] == 'X' or nums[i + 1] == 'V')){
				total -= 1;
			}
			else if(nums[i] == 'X' and (nums[i + 1] == 'L' or nums[i + 1] == 'C')){
				total -= 10;
			}
			else if(nums[i] == 'C' and (nums[i + 1] == 'D' or nums[i + 1] == 'M')){
				total -= 100;
			}
			else{
				total += current_value;
			}
		}
		
		return total;
	};
};


int main(){
	Solution obj;
	string roman = "MCMXCIV";
	int romanInt = obj.romanToInt(roman);
	cout << "The integer value of " << roman << " is " << romanInt << endl;
    
	/*
	for(int i = 0; i < s.size(); i++){
		cout << s[i] << endl;
	}
	*/
	return 0;
};
