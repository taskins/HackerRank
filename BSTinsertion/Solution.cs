/*
Node is defined as

typedef struct node
{
   int data;
   node * left;
   node * right;
}node;

*/


node * insert(node * root, int value)
{
    // create the new node
    node *toInsert = new node;
    toInsert->data = value;
    toInsert->left = NULL;
    toInsert->right = NULL;

    // hold a pointer to traverse

    if ( root == NULL)
        {
        root = toInsert;

    }

    else if(value < root->data )
        {

        root->left = insert(root->left, value);
    }

    else if (value > root->data )
        {

        root->right = insert(root->right, value);
    }

    return root;

}
