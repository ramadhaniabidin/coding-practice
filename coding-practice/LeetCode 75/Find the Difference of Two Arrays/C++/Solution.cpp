#include <iostream>
#include <vector>
#include <set>
#include <algorithm>

using namespace std;

class Helper{
    private:

    public:
        bool doesExist(int x, vector<int>& arr){
            for(const auto i: arr){
                if (i == x){
                    return true;
                }
            }
            return false;
        }


};

class Solution{
    private:

    public:
        Helper helper;
        vector<vector<int>> findDifference(vector<int>& nums1, vector<int>& nums2){
            set<int> set1(nums1.begin(), nums1.end());
            set<int> set2(nums2.begin(), nums2.end());

            vector<int> num1(set1.begin(), set1.end());
            vector<int> num2(set2.begin(), set2.end());

            vector<int> ans1;
            vector<int> ans2;
            vector<vector<int>> ans;

            for(const auto i: num1){
                if(helper.doesExist(i, num2) == false){
                    ans1.push_back(i);
                }
            }

            for(const auto i: num2){
                if(helper.doesExist(i, num1) == false){
                    ans2.push_back(i);
                }
            }

            ans.push_back(ans1);
            ans.push_back(ans2);

            return ans;
        }
};


int main(){
    Solution solution;
    vector<int> nums1 = {1,2,3,3};
    vector<int> nums2 = {1,1,2,2};
    vector<vector<int>> ans = solution.findDifference(nums1, nums2);

    for(const auto vec: ans){
        cout << "{" ;
        for (size_t i = 0; i < vec.size(); ++i) {
            cout << vec[i];
            if (i < vec.size() - 1) {
                cout << " ";
            }
        }
        cout << "}";
        cout << endl;
    }
    return 0;
}