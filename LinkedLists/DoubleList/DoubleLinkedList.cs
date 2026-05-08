using Shared;
using DoubleList;

public class DoubleLinkedList<T> : ILinkedList<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public DoubleLinkedList()
    {
        _head = null;
        _tail = null;
    }

    override public string ToString()
    {
        var current = _head;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Next;
        }
        result += "null";
        return result;
    }

    public string ToStringReverse()
    {
        var current = _tail;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Previous;
        }
        result += "null";
        return result;
    }

    public void InsertAtBeginning(T data)
    {
        var newNode = new Node<T>(data);
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
        }
    }

    public void InsertAtEnding(T data)
    {
        var newNode = new Node<T>(data);
        if (_tail == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            newNode.Previous = _tail;
            _tail = newNode;
        }
    }
    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }
    public void Remove(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            { 
                if (current == _head) // Found at the head
                {
                    _head = current.Next;
                    _head!.Previous = null;
                }
                else if (current == _tail) // Found at the tail
                {
                    _tail = current.Previous;
                    _tail!.Next = null;
                }
                else // Found in the middle
                {
                    current.Previous!.Next = current.Next;
                    current.Next!.Previous = current.Previous;
                }
                return;
            }
            current = current.Next;
        }
    }
    public void Reverse()
    {
        Node<T>? previous = null;
        var current = _head;
        while (current != null)
        {
            var next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }
        _head = previous;
    }
}