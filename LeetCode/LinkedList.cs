

public class Node
{
    public  int value { get; set; }
    public Node next { get; set; }
    public Node(int value)
    {
        this.value = value;
        this.next = null;
    } 
}

public class LinkedList
{
    private Node head;
    private Node tail;
    private int length;

    public LinkedList(int value) {
        this.head = new Node(value);
        this.tail = this.head;
        this.length = 1;
    }

    public int getLength() { return length; }
    public Node getHead() { return head; }
    public Node getTail() { return tail; }

    public void appendNode(int value)
    {
        var newNode = new Node(value);
        this.tail.next = newNode;
        this.tail = newNode;
        this.length++;
    }

    public void prependNode(int value)
    {
        var newNode = new Node(value);
        newNode.next = this.head;
        this.head = newNode;
        this.length++;
    }

    public void printList()
    {
        if (this.head == null)
        {
            return;
        }
        Node current = this.head;
        while (current != null)
        {
            Console.Write("-->" + current.value);
            current = current.next;
        }
        Console.WriteLine();
    }

    public void insert(int index, int value)
     {
      

        Node newNode = new Node(value);
        Node leader = traverseToIndex(index - 1); 
        newNode.next = leader.next;
        leader.next = newNode;
        this.length++;

    }
    private int wrapIndex(int index)
    {
        return Math.Max(Math.Min(index, this.length - 1), 0);
    }

    public void removenode(int index)
    {
        var leader = traverseToIndex(index - 1);
        var unwantedNode = leader.next;
        leader.next = unwantedNode.next;
        length--;

    }

    private Node traverseToIndex(int index)
    {
        int counter = 0;
 
        Node currentNode = head;
        while (counter != index)
        {
            currentNode = currentNode.next;
            counter++;
        }
        return currentNode;
    }
}



 