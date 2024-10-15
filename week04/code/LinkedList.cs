using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;

public class LinkedList : IEnumerable<int>
{
    private Node? _head;
    private Node? _tail;

    /// <summary>
    /// Insert a new node at the front (i.e. the head) of the linked list.
    /// </summary>
    public void InsertHead(int value)
    {
        // Create new node
        Node newNode = new(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        // If the list is not empty, then only head will be affected.
        else
        {
            newNode.Next = _head; // Connect new node to the previous head
            _head.Prev = newNode; // Connect the previous head to the new node
            _head = newNode; // Update the head to point to the new node
        }
    }

    /// <summary>
    /// Insert a new node at the back (i.e. the tail) of the linked list.
    /// </summary>
    public void InsertTail(int value)
    {
        // TODO Problem 1
        Node newTail = new(value);
        if(_tail is null){
            _tail = newTail;
            _head = newTail;
        } else{
            newTail.Prev = _tail;
            _tail.Next = newTail;
            _tail = newTail;
        }
    }


    /// <summary>
    /// Remove the first node (i.e. the head) of the linked list.
    /// </summary>
    public void RemoveHead()
    {   
        
        if (_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        
        else if (_head is not null)
        {
            _head.Next!.Prev = null; 
            _head = _head.Next; 
        }
    }


    /// <summary>
    /// Remove the last node (i.e. the tail) of the linked list.
    /// </summary>
    public void RemoveTail()
    {
        // TODO Problem 2
        if(_tail == _head){
            _tail = null;
            _head = null;
        }
        else if(_tail is not null){
                _tail.Prev!.Next = null;
                _tail = _tail.Prev;
        }
    }

    /// <summary>
    /// Insert 'newValue' after the first occurrence of 'value' in the linked list.
    /// </summary>
    public void InsertAfter(int value, int newValue)
    {
        
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Data == value)
            {
                
                
                if (curr == _tail)
                {
                    InsertTail(newValue);
                }
                else
                {
                    Node newNode = new(newValue);
                    newNode.Prev = curr; 
                    newNode.Next = curr.Next; 
                    curr.Next!.Prev = newNode;
                    curr.Next = newNode; 
                }

                return; 
            }

            curr = curr.Next; 
        }
    }

    /// <summary>
    /// Remove the first node that contains 'value'.
    /// </summary>
    public void Remove(int value)
    {
        // TODO Problem 3
        Node? curr =_head;
        
        while (curr != null) {
            try{
                
                if(curr.Data == value){
                if(curr == _head){
                    RemoveHead();
                }
                else if(curr == _tail){
                    RemoveTail();
                }else{
                    curr.Prev!.Next = curr.Next;
                    curr.Next!.Prev = curr.Prev;
                }
                }            
            }
        catch {
                Debug.WriteLine("The value is not in the linklist (Remove)");
                return;
            }
        curr = curr.Next;
    } }

    /// <summary>
    /// Search for all instances of 'oldValue' and replace the value to 'newValue'.
    /// </summary>
    public void Replace(int oldValue, int newValue)
    {
        // TODO Problem 4
        Node? curr = _head;
        Node? newNode = new(newValue);
        while(curr != null){
            try{
                if(curr.Data == oldValue){
                    curr.Data = newValue;
                } 
                else if(curr == _tail){
                    
                    InsertTail(newValue);
                } else{
                    curr.Prev!.Next = newNode;
                    curr.Next!.Prev = curr.Prev;
                    curr.Prev = newNode;
                    curr.Next = curr.Next!.Next;
                    curr.Next!.Prev = curr;
                }
                return;
            } catch{
                Debug.WriteLine("The value is not in the linklist");
                break;
            }
            // curr = curr.Next;
        }
    }

    /// <summary>
    /// Yields all values in the linked list
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        // call the generic version of the method
        return this.GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the Linked List
    /// </summary>
    public IEnumerator<int> GetEnumerator()
    {
        var curr = _head; // Start at the beginning since this is a forward iteration.
        while (curr is not null)
        {
            yield return curr.Data; // Provide (yield) each item to the user
            curr = curr.Next; // Go forward in the linked list
        }
    }

    /// <summary>
    /// Iterate backward through the Linked List
    /// </summary>
    public IEnumerable Reverse()
    {
        // TODO Problem 5
        var curr = _tail; 
        while (curr is not null)
        {
            yield return curr.Data; 
            curr = curr.Prev; 
        }
        
    }

    public override string ToString()
    {
        return "<LinkedList>{" + string.Join(", ", this) + "}";
    }

    // Just for testing.
    public Boolean HeadAndTailAreNull()
    {
        return _head is null && _tail is null;
    }

    // Just for testing.
    public Boolean HeadAndTailAreNotNull()
    {
        return _head is not null && _tail is not null;
    }
}

public static class IntArrayExtensionMethods {
    public static string AsString(this IEnumerable array) {
        return "<IEnumerable>{" + string.Join(", ", array.Cast<int>()) + "}";
    }
}