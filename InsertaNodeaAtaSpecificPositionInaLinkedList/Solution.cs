/*
  Insert Node at a given position in a linked list
  head can be NULL
  First element in the linked list is at position 0
  Node is defined as
  struct Node
  {
     int data;
     struct Node *next;
  }
*/
  // Complete this method only
  // Do not write main function.

Node* InsertNth(Node *head, int data, int position)
{
    Node *insNode = new Node; // create a new node
    insNode->data = data;
    insNode->next = NULL;

    //case 1: empty list

    if ( head == NULL)
        {
        head = insNode;
        return insNode;

    }

    // case 2 : first in line

    if ( position == 0 )
        {
        insNode->next = head;
        head = insNode;
        return insNode;
    }

    //case 3: all others


    Node * current = head;

    while ( position - 1  > 0 )
    {
         current = current->next;
         position--;
    }

    insNode->next = current->next;
    current->next = insNode;

    return head;
}
