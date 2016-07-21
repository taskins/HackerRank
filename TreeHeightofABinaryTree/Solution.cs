
/*The tree node has data, left child and right child
struct node
{
    int data;
    node* left;
    node* right;
};

*/
int height(node * root)
{

    if (root == NULL)
        {
        return -1;
    }
    int rightHeight = height(root->right);
    int leftHeight =  height(root->left);

   return max(rightHeight,leftHeight ) +1 ;



}
