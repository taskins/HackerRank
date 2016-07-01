/*
 Delete Node at a given position in a linked list
 Node is defined as
 struct Node
 {
 int data;
 struct Node *next;
 }
 */
Node* Delete(Node *head, int position)
{
	
	// Complete this method
	
	int count = 0 ;
	Node *current; // node pointer ( to check where you are)
	Node *temp; //  node pointer (to delete the node)
	
	if (head -> next == NULL)
	{
		head == NULL;
		return head;
	}
	if (head->next != NULL && position == 0 )
	{
		temp = head;
		head = head->next;
		delete temp;
		temp = NULL;
		return head;
	}
	
	current = head;
	while( count != position-1 ) // stop right before the position
	{
		current = current->next;
		count++;
	}
	temp = current->next;
	current->next = current->next->next;
	delete temp;
	temp= NULL;
 
	return head;
}
