//
//  main.cpp
//  Hacker Rank
//
//  Created by Selen Taskin on 2/12/17.
//  Copyright © 2017 Selen Taskin. All rights reserved.
//



/*
 Find merge point of two linked lists
 Node is defined as */
 struct Node
 {
 int data;
 Node* next;
 };
 
#include <stack>
using namespace std;
int FindMergeNode(Node *headA, Node *headB)
{
	stack <int> a;
	stack <int> b;
	
	Node *curA = headA;
	Node *curB = headB;
	
	int top =0;
	
	
	
	while(curA->next != NULL)
	{
		a.push(curA->data);
		curA = curA->next;
	}
	a.push(curA->data); // push the last one
	
	while(curB->next != NULL)
	{
		b.push(curB->data);
		curB = curB->next;
	}
	b.push(curB->data); // push the last one
	
	while (a.top() == b.top())
	{
		top = a.top();
		a.pop();
		b.pop();
		
	}
	
	return top;
	
	
}

