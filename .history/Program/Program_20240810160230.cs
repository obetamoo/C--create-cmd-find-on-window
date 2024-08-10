namespace Program;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Find");
        args.Append(System.Console.ReadLine());
        if (args.Length == 0)
        {
            System.Console.WriteLine("0");
        }
    }
}
