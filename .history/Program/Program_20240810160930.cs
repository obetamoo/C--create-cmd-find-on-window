namespace Program;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Find");
        string? inputPara = Console.ReadLine();

        string[] convertToArray = inputPara.Split(" ");

        for (int i = 0; i < convertToArray.Length; i++)
        {
            System.Console.WriteLine(convertToArray[i]);
        }
        if (convertToArray.Length == 0)
        {
            System.Console.WriteLine("0");
        }
    }
}
