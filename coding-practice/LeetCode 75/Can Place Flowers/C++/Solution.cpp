#include <iostream>
#include <vector>
using namespace std;

class Solution{
	private:
		
	public:
		bool canPlantFlowers(vector<int>& flowerbed, int n){
			int flowers_planted = 0;
			for(int i = 0; i < flowerbed.size(); i++){
				if(flowerbed[i] == 0){
					bool left_empty = (i == 0) || (flowerbed[i - 1] == 0);
					bool right_empty = (i == flowerbed.size() - 1) || (flowerbed[i + 1] == 0);
					cout << "Current position " << i << ", left_empty: " << (left_empty ? "yes":"no") << ", right_empty: " << (right_empty ? "yes":"no")<< endl;
					
					
					if (left_empty and right_empty){
						flowerbed[i] = 1;
						flowers_planted += 1;
					}
				}
			}
			
			return flowers_planted >= n;
		}
		
};

int main(){
	Solution obj;
	
	int arr[] = {1,0,0,0,0,1,0};
	vector<int> flowerbed(arr, arr + sizeof(arr) / sizeof(int));
	int n = 1;
	
	cout << "Can place flowers?: " << (obj.canPlantFlowers(flowerbed, n) ? "yes":"no");
	
	return 0;
}
