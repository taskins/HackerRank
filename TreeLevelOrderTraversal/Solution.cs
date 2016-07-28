
/*
struct node
{
    int data;
    node* left;
    node* right;
}*/

#include <queue>

void LevelOrder(node * root)
{

    queue <node *> Q; // to hold right and left child.

    Q.push(root);
    node *current = Q.front();


    while(!Q.empty())
        {
        node *current = Q.front();
        cout << current-> data << " ";
        if(current->left != NULL)
            {
            Q.push(current->left);
        }
        if(current->right !=NULL)
            {
            Q.push(current->right);
        }

        Q.pop();// remove element from the front

    }



}
