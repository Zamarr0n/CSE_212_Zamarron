public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {

        // TODO Start Problem 1
        if(value == Data){
            return;
        }
        else if (value < Data)
        {
            // Insert to the left
        if( Left == null){
                Left = new Node(value);
            }
            else{
                Left.Insert(value);
            }
        }
        else
        {
            if (Right == null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
            return true;
        else if (value < Data)
            if(Left != null){
                return Left.Contains(value);
            }
            else{
                return false;
            }
        else
            if(Right != null){
                return Right.Contains(value);
            }
            else {
                return false;
            }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight;
        int rightHeight;
        if (Left == null)
        {
            leftHeight = 0;
        }
        else
        {
            leftHeight = Left.GetHeight();
        }

        if (Right == null)
        {
            rightHeight = 0;
        }
        else
        {
            rightHeight = Right.GetHeight();
        }
        int heightOfCurrentNode = 1 + Math.Max(leftHeight, rightHeight);
        return heightOfCurrentNode;
    }
}