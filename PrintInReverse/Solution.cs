/*
  Print elements of a linked list in reverse order as standard output
  head pointer could be NULL as well for empty list
  Node is defined as
  struct Node
  {
     int data;
     struct Node *next;
  }
*/
#include <stack>
#include <iostream>
#include <string>

using namespace std;

void ReversePrint(Node *head)
{
  // This is a "method-only" submission.
  // You only need to complete this method.
  
// solution 1 : brute force with stack
    Node *current = head;
    stack <int> printStack; // initialize a stack to hold
    if(head != NULL)
       {
    while (current->next != NULL) // put items in a stack
        {
        printStack.push(current->data);
        current = current->next;
    }

    printStack.push(current->data);// push the last node

    while(!printStack.empty())// pop and display
        {
          cout << printStack.top() << endl;
          printStack.pop();
        }

   }
   //solution 2: recursion

if( head != NULL)
    {
      ReversePrint(head->next);
      cout << head->data << endl;
}


}
