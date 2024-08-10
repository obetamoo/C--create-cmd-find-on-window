
namespace Program;

class Program
{
    static void Main(string[] args)
    {
        var convertToArray = GetParas();


        if (convertToArray.Length == 0 || string.IsNullOrEmpty(inputPara))
        {
            System.Console.WriteLine("FIND: Parameter format not correct");
        }

    }

    private static object GetParas()
    {
        System.Console.Write("Find");
        string? inputPara = Console.ReadLine();

        string[] convertToArray = inputPara.Split(" ");
        return convertToArray;
    }
}
