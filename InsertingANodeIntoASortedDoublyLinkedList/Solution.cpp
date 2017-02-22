/*
    Insert Node in a doubly sorted linked list
    After each insertion, the list should be sorted
   Node is defined as
   struct Node
   {
     int data;
     Node *next;
     Node *prev;
   }
*/
Node* SortedInsert(Node *head,int data)
{

    // Complete this function
   // Do not write the main method.

    // create a new node
    Node *insert = new Node;
    insert->data = data;
    insert->next = NULL;
    insert->prev = NULL;


    if ( head == NULL)
        {
        head = insert;
        return insert;
        }
    else if ( insert->data <= head->data) // if insert will be the first node
        {
        insert->next = head;
        head->prev = insert;
        head = insert;
        return head;
        }
    else
        {
        Node *previous = head;
        Node *current = head->next;
        while (current != NULL)
            {
            if (previous->data <=insert->data &&insert->data <= current->data  )
               {
               previous->next = insert;
               insert->prev = previous;
               insert->next = current;
               current->prev = insert;
               return head;
               }
            previous=current;
            current = current->next;
            }

            // insert at the end of the list
            previous->next = insert;
            insert->prev = previous;
            return head;

    }
} 
