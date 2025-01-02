#include<iostream>
#include<cmath>
#include<vector>
#include<sstream>

using namespace std;

class Solution{
	private:
	
	
	public:
		void HelloWorld(){
			cout << "Hello World";	
		};
		
		string longestCommonPrefix(vector<string>& words){
			if(words.size() == 0){
				return "";
			}
			
			string prefix = words[0];
			
			for(int i = 1; i < words.size(); i++){
				while(words[i].substr(0, prefix.size()) != prefix){
					prefix.resize(prefix.size() - 1);
					if(prefix.empty()){
						return "";
					}
				}
			}
			
			return prefix;	
		};
		
		void
};

vector<string> split(const string&, char delimiter){
	vector<string> tokens;
	string token;
	istringStream tokenStream()
};

int main(){
	/*
	Solution obj;
	string arr_words[] = {"flower","flow","flight"};
	vector<string> words(arr_words, arr_words + sizeof(arr_words) / sizeof(string));
	string longestPrefix = obj.longestCommonPrefix(words);
	
	cout << "The longest common prefx of {";
	for(int i = 0; i < words.size(); i++){
		if(i + 1 != words.size()){
			cout << words[i] << ", ";
		}
		else{
			cout << words[i];
		}
	}
	cout << "} is " << longestPrefix << endl;
	*/
	
	string input_string = "apple,banana,cherry";
	char delimiter = ',';
	vector<string> result = 
	return 0;
}

