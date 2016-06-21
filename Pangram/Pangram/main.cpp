

#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
	/* Enter your code here. Read input from STDIN. Print output to STDOUT */
	string s;
	string alphabet = "abcdefghijklmnopqrstuvwxyz";
	bool pangram = true;
	
	// read input
	getline (cin, s);
	
	//if length of the string is less than 26, it is not pangram
   	if ( s.length() < 26)
	{
		pangram = false;
	}
	
	// check if its in alphabet and convert
	for(int i =0; i < s.length(); i++)
	{
		if((s[i] >=65 && s[i] <=90) || (s[i] >= 97 && s[i]<=122))
		{
			//if all alphabetic convert to lower case
			s[i] = tolower(s[i]);
		}
		//else pangram is still false
		
	}
	
	//sort
	sort(s.begin(),s.end());
	
	//delete duplicates
	int stringLength = s.length() -1;
	
	for(int i = 0 ; i < stringLength; i++)
	{
		for(int j = i +1; j < stringLength;)
		{
			if(s[i]==s[j]) //if two conjugative char are same then..
			{
				//replace the first char with last char of string and reduce the length of string
				s[j]=s[--stringLength];
				
			}
			else
			{
				j++;
			}
			
		}
	}
	
	//remove the elements from the end of the string
	s = s.substr(0, stringLength);
	

	// sort again
	sort(s.begin(),s.end());

	
	// erase whitespace
	int m = s.length();
	int i=0;
	while(i<m)
	{
		while(s[i] == 32)
			s.erase(i,1);
		i++;
	}

 
	int count = 0; // flag for pangram
	
	// check flag
	for( int i = 0 ; i < s.length(); i++)
	{
		if(alphabet[i] == s[i])
		{
			count = count;
		}
		else
		{
			count += 1;
		}
		
	}
	
	// display if it is pangram
	if ((pangram == true) && count == 0)
	{
		cout << "pangram";
	}
	else
	{
		cout << "not pangram";
	}
	

	
	return 0;
}
