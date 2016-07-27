/*
struct node
{
    int data;
    node* left;
    node* right;
};

*/

#include<queue>
#include<stack>

void top_view(node * root)
{
    stack < node*> S; // for left side
    queue <node *> Q; // for right side

    node * headLeft = root;
    node * headRight = root;

   // hold values in a stack for left side
    while(headLeft != NULL)
        {

        S.push(headLeft);
        headLeft = headLeft->left;

        }
    while(!S.empty())
        {

        node *current = S.top();
        cout <<  current->data << " ";
        S.pop();

        }

    //hold values in a queue for right side
        headRight = headRight->right; // we already print out the root in left side
        while(headRight != NULL)
        {

        Q.push(headRight);
        headRight = headRight->right;

        }

        while(!Q.empty())
        {

        node *current2 = Q.front();
        cout <<  current2->data << " ";
        Q.pop();

        }



}
