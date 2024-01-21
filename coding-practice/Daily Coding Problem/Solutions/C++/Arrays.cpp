#include<iostream>
using namespace std;
class Arrays{
	string message = "hello";
	int myArray[3] = {1, 2, 3};
	
	public:
	void hello(){
		int arrayLength = sizeof(myArray)/sizeof((myArray[0]));
		cout<<"The length of myArray is: "<<arrayLength<<endl;
	}
	
	// void myProductAnswer(int input[5]){
	// 	for(i = 0; i < 5; i++){
			
	// 	}
	// }
};

int main(){
	Arrays myObject;
	myObject.hello();

	return 0;
}
