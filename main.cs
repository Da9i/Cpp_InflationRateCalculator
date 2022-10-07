#include<iostream>
using namespace std;
void inflation(double& cp, double& py)
{
	int opt;
	cout << "ENTER CURRENT PRICE :";
	cin >> cp;
	cout << "ENTER 1 TO FIND INFLATION FOR 1 YEAR\nENTER 2 TO FIND INFLATION FOR 2 YEARS\n";
	cin >> opt;
	if (opt == 1)
	{
		cout << "ENTER PRICE A YEAR AGO:";
		cin >> py;
		double result = cp - py;
		result = result/py*100;
		cout << "INFLATION RATE = " << result<<"%"<<endl;
	}
	else if (opt == 2)
	{
		cout << "ENTER PRICE TWO YEARS AGO:";
		cin >> py;
		double result = cp - py;
		cout << "INFLATION RATE = " << result/py*100 <<"%"<<endl;
	}
}
int main() 
{
	double currentprice, priceyear;
	inflation(currentprice, priceyear);
	system("pause>0");
}
