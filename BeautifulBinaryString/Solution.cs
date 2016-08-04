#include <map>
#include <set>
#include <list>
#include <cmath>
#include <ctime>
#include <deque>
#include <queue>
#include <stack>
#include <string>
#include <bitset>
#include <cstdio>
#include <limits>
#include <vector>
#include <climits>
#include <cstring>
#include <cstdlib>
#include <fstream>
#include <numeric>
#include <sstream>
#include <iostream>
#include <algorithm>
#include <unordered_map>

using namespace std;


int main(){
    int n;
    cin >> n;
    string B;
    cin >> B;

    int counter = 0 ;

    for ( int i = 0 ; i < n ; i++)
        {
        if ( B[i] == 48 && B[i+1] == 49 && B[i+2] == 48) // in ascii 48 is 0 and 49 is 1 // or we can use B[i] = '0'                                                             // and B[i] = '1'
            {
            B[i+2]= 49;
            counter++;
        }
    }

    cout << counter;


    return 0;
}
