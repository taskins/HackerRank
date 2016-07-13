/*
  Reverse a linked list and return pointer to the head
  The input list will have at least one element
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
#include <list>

using namespace std;
Node* Reverse(Node *head)
{
  // Complete this method
    // just reverse the links
    // a->b->c->null
    // becomes null<-a<-b<-c

    // solution 1 : iterative solution
 /*
    Node *current;
    Node *previous;
    Node *nextNode;

    current = head;
    previous = NULL;


    while( current != NULL)
        {
        nextNode = current->next;
        current->next = previous;
        previous = current;
        current = nextNode;


    }

    head = previous;
    return head;
 */
    //solution 2 : recursive solution

    if ( head == NULL || head->next == NULL)
        {
        return head;
    }

    Node * remaining = Reverse(head->next);
    head ->next->next = head;
    head->next = NULL;

    return remaining;




}
