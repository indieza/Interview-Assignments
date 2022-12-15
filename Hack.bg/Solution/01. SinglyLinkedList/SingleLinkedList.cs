namespace _01._SinglyLinkedList
{
    using System;

    public class SingleLinkedList
    {
        public SingleLinkedList()
        {
        }

        public Node Head { get; set; }

        public void InsertFront(SingleLinkedList singlyList, int newData)
        {
            Node node = new Node(newData)
            {
                Next = singlyList.Head
            };

            singlyList.Head = node;
        }

        public void PrintList(Node temp)
        {
            while (temp != null)
            {
                Console.Write($"{temp.Data} ");
                temp = temp.Next;
            }

            Console.WriteLine();
        }

        public SingleLinkedList DeleteByIndex(int index, SingleLinkedList list)
        {
            var currentIndex = 0;
            Node currentNode = list.Head;
            SingleLinkedList result = new SingleLinkedList();

            while (currentNode != null)
            {
                if (currentIndex != index)
                {
                    result.InsertFront(result, currentNode.Data);
                }

                currentNode = currentNode.Next;
                currentIndex++;
            }

            return result;
        }

        public SingleLinkedList Delete(int number, SingleLinkedList list)
        {
            Node previousNode = null;
            Node currentNode = list.Head;
            SingleLinkedList result = new SingleLinkedList();

            while (currentNode != null)
            {
                if (currentNode.Data > number)
                {
                    if (previousNode == null)
                    {
                        previousNode = currentNode.Next;
                    }
                    else
                    {
                        previousNode.Next = currentNode.Next;
                    }
                }
                else
                {
                    result.InsertFront(result, currentNode.Data);
                    previousNode = currentNode;
                }

                currentNode = currentNode.Next;
            }

            return result;
        }
    }
}