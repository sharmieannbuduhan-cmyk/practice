class Program
{
    static void Main(string[] args)
    {
        Queue<int> items = new Queue<int>();
        Queue<int> score = new Queue<int>();
        score.Enqueue(2);
        score.Enqueue(7);
        score.Enqueue(5);
        score.Enqueue(8);
        score.Enqueue(1);
        score.Dequeue();
        Console.WriteLine($"First Peek: {score.Peek()}");
        score.Enqueue(0);
        score.Enqueue(3);
        Console.WriteLine($"Second Peek: {score.Peek()}");
        score.Dequeue();
        score.Enqueue(4);
        Console.Write("Items: ");
        printItems(score);
        Console.Write("Enter score to be search: ");
        int item2Search =
        Convert.ToInt32(Console.ReadLine());
        if (score.Contains(item2Search))
            Console.WriteLine("The score is found!");
        else
            Console.WriteLine("The score not found!");
    }
    private static void printItems(Queue<int> items)
    {
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n");
    }
}
