#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */

    string  input = "";

    cin >> input;

     int i = 0 ;
     while(input[i] != '\0') // while it is not at the end of the string
         {


        if( input[i] == input[i+1]) // compare chars
            {
            input.erase(input.begin()+i); // delete duplicates
            input.erase(input.begin()+i);
            i=0; // start all over

        }
         else
             {
             i++; // if no duplicate then continue
         }
    }

        if( input.length() == 0 )
            {
            cout << "Empty String";
        }





    cout << input;
    return 0;
}
