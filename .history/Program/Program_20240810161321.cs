
namespace Program;

class Program
{
    static void Main(string[] args)
    {
        var convertToArray = getParas();


        if (convertToArray.Length == 0 || string.IsNullOrEmpty(inputPara))
        {
            System.Console.WriteLine("FIND: Parameter format not correct");
        }

    }

    private static object getParas()
    {
        throw new NotImplementedException();
    }
}
