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

	void product(int inputArray[4])
	{
		int calculatedValue = 1;
		int productArray[4] = {0, 0, 0, 0};
		for (int i = 0; i < 4; i++)
		{
			
			for (int j = 3; j >= 0; j--)
			{
				
				if (i != j)
				{
					calculatedValue *= inputArray[j];
				}
				
			}
			productArray[i] = calculatedValue;
			calculatedValue = 1;
		}

		cout << "The original array: " << endl;
		cout << "[";
		for (int i = 0; i < 4; i++)
		{
			if (i != 3)
			{
				cout << inputArray[i] << ", ";
			}
			else
			{
				cout << inputArray[i] << "";
			}
		}
		cout << "]" << endl;

		cout << "\nThe product array: " << endl;
		cout << "[";
		for (int i = 0; i < 4; i++)
		{
			if (i != 3)
			{
				cout << productArray[i] << ", ";
			}
			else
			{
				cout << productArray[i] << "";
			}
		}
		cout << "]" << endl;
	}
	// void myProductAnswer(int input[5]){
	// 	for(i = 0; i < 5; i++){

	// 	}
	// }
};

int main()
{
	Arrays myObject;

	int input[4] = {1, 2, 3, 4};
	myObject.product(input);

	return 0;
}
