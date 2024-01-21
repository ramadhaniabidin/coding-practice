#include <iostream>
using namespace std;
class Arrays
{
	string message = "hello";
	int myArray[3] = {1, 2, 3};

public:
	void hello()
	{
		int arrayLength = sizeof(myArray) / sizeof((myArray[0]));
		cout << "The length of myArray is: " << arrayLength << endl;
	}

	int *returningArray()
	{
		static int outputArray[2] = {1, 2};
		return outputArray;
	}
	// void myProductAnswer(int input[5]){
	// 	for(i = 0; i < 5; i++){

	// 	}
	// }
};

int main()
{
	Arrays myObject;
	int *myArray = myObject.returningArray();
	// myObject.hello();
	cout << "[";
	for (int i = 0; i < 2; i++)
	{
		/* code */
		if (i != 1)
		{
			cout << myArray[i] << ", ";
		}
		else
		{
			cout << myArray[i] << "";
		}
	}
	cout << "]";

	return 0;
}
