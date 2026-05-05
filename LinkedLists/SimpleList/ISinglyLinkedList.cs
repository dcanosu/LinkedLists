using SimpleList;

public interface ISinglyLinkedList<T>
{
    bool Contains(T data);
    void InsertAtBeginning(T data);
    void InsertAtEnding(T data);
    void Remove(T data);
    void Reverse();
    string ToString();
}
