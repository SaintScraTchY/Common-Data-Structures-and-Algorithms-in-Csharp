using LinkedLists.DoubleLinkedList.DataType;

namespace LinkedLists.DoubleLinkedList.Example;

public static class Sample
{
    private static readonly LinkedList _linkedList = new LinkedList();
    public static void ExecuteSample()
    {
        Console.WriteLine("Insertion Example");
        Insertions();
        Console.WriteLine("Deletion Example");
        Deletion();
    }
    
    private static void Insertions()
    {
        _linkedList.InsertStart(5);
        _linkedList.InsertStart(4);
        _linkedList.InsertStart(3);
        _linkedList.InsertStart(2);
        _linkedList.InsertStart(1);
        _linkedList.InsertStart(333);
        _linkedList.InsertStart(444);
        _linkedList.InsertStart(555);
        _linkedList.InsertStart(0);
        
        _linkedList.InsertAt(3,0);
        
        _linkedList.InsertEnd(999);
        
        Console.WriteLine("List After InsertOperations");
        _linkedList.DisplayNodes();
    }
    
    private static void Deletion()
    {
        _linkedList.DeleteEnd();
        
        _linkedList.DeleteAt(2);
        
        _linkedList.DeleteFirst();
        _linkedList.DeleteFirst();
        _linkedList.DeleteFirst();

        Console.WriteLine("List After DeleteOperations");
        _linkedList.DisplayNodes();
    }
}