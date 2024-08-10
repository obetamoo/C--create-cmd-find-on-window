

namespace Program;

class Program
{
    static void Main(string[] args)

    {
        System.Console.Write("Find");
        string? inputPara = Console.ReadLine();

        string[] convertToArray = GetParas(inputPara);
        if (convertToArray.Length == 0 || string.IsNullOrEmpty(inputPara))
        {
            System.Console.WriteLine("FIND: Parameter format not correct");
            return;
        }
        var Option = new SetOption();

        insertParaForOption(Option, convertToArray);
    }

    private static void insertParaForOption(SetOption option, string[] convertToArray)
    {
        foreach (var s in convertToArray)
        {
            if (s == "/c")
            {
                option.countLine = true;
            }
            else if (s == "/i")
            {
                option.haveDifferentLowAndHighCase = false;
            }
            else if (s == "/h")
            {
                option.helpMode = true;
            }
            else
            {
                if (string.IsNullOrEmpty(option.stringToFind))
                {
                    option.stringToFind = s;
                }
                else if (string.IsNullOrEmpty(option.path))
                {
                    option.path = s;
                }
                else
                {
                    throw new ArgumentException(s);
                }
            }
        }
    }

    private static string[] GetParas(string input)
    {
        string[] convertToArray = input.Split(" ");
        return convertToArray;
    }
}
