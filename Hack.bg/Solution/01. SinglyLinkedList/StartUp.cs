namespace _01._SinglyLinkedList
{
    using System;

    public class StartUp
    {
        private static void Main()
        {
            Console.Write($"n = ");
            int n = int.Parse(Console.ReadLine());
            var list = new SingleLinkedList();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.InsertFront(list, number);
            }

            Console.Write("List: ");
            list.PrintList(list.Head);

            Console.Write($"Delete Number: ");
            int range = int.Parse(Console.ReadLine());
            SingleLinkedList newList = list.Delete(range, list);

            Console.Write("New List: ");
            list.PrintList(newList.Head);
        }
    }
}