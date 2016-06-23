
//*****************************************************************************
//**  Date: June 2016
//**  Author: Selen Taskin
//**  Description: Solution to HackerRank problem called
//**  "Alternating Characters"
//*****************************************************************************


#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <string>

using namespace std;


int main() {
	/* Enter your code here. Read input from STDIN. Print output to STDOUT */
	int number; // get the number of lines
	cin >> number;

    string inputs[number]; // initialize an array to hold each line of string
	string input; // initialize a string to refer each item in the arrasy
	
	int ascii =0; // initilize a variable to count total ascii of a given string
	
	int countDeletion = 0; // iniliaze a variable to count number of deletions
	
	//read rest into an array
	for (int i =0; i < number; i ++)
	{
		cin >> input;
		inputs[i] = input;
	}
	
	
	
	
	//get each input
	for (int i =0; i < number; i ++)
	{
		input = inputs[i];
		
		
		countDeletion = 0; //reset countDeletion each time
		for(int j = 0 ; j < input.length()-1 ; j++)
		{
			if( input[j] == input[j+1])
			{
				countDeletion++; // if adjacents are the same increase the count
			}
			else
			{
				countDeletion = countDeletion; // if they are different
			}
			
			
		}
		
		cout << countDeletion << endl;
		
  
	}
	
	
	
	return 0;
}