using System;
using System.Collections.Generic;

public class Queue
{
    private List<int> elements = new List<int>();

    public void Push(int item)
    {
        elements.Add(item);
        Console.WriteLine("ok");
    }

    public void Pop()
    {
        if (elements.Count > 0)
        {
            Console.WriteLine(elements[0]);
            elements.RemoveAt(0);
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    public void Front()
    {
        if (elements.Count > 0)
        {
            Console.WriteLine(elements[0]);
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    public void Size()
    {
        Console.WriteLine(elements.Count);
    }

    public void Clear()
    {
        elements.Clear();
        Console.WriteLine("ok");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Queue queue = new Queue();
        string command;

        do
        {
            command = Console.ReadLine();
            string[] splitCommand = command.Split(' ');

            switch (splitCommand[0])
            {
                case "push":
                    queue.Push(int.Parse(splitCommand[1]));
                    break;
                case "pop":
                    queue.Pop();
                    break;
                case "front":
                    queue.Front();
                    break;
                case "size":
                    queue.Size();
                    break;
                case "clear":
                    queue.Clear();
                    break;
            }
        } while (command != "exit");

        Console.WriteLine("bye");
    }
}
