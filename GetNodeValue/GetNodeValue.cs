/*
  Get Nth element from the end in a linked list of integers
  Number of elements in the list will always be greater than N.
  Node is defined as
  struct Node
  {
     int data;
     struct Node *next;
  }
*/
int GetNode(Node *head,int positionFromTail)
{
  // This is a "method-only" submission.
  // You only need to complete this method.

    Node *current;
    int count = 0 ;
    current = head;
    if (positionFromTail == 0)  // if last node
        {
        while ( current->next != NULL)
            {
            current = current->next;
        }
      return current->data;
    }

     while ( current->next != NULL)
            {
            current = current->next;
            count++;
        }

    current = head;
    if (count == positionFromTail )  // if first node
        {
        return current->data;
    }
    else // for any other position
        {
        current = head;
        int positionFromHead = 0;
        positionFromHead = count - positionFromTail;
        for( int i = 0 ; i < positionFromHead; i++ )
            {
            current = current->next;
        }
       return current->data;
    }

}
