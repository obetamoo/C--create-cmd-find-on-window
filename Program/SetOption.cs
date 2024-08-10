using System;

namespace Program;

public class SetOption
{
    public string stringToFind { get; set; } = "";
    public bool haveDifferentLowAndHighCase { get; set; } = true;
    public bool countLine { get; set; } = false;

    public bool helpMode { get; set; } = false;
    public string path { get; set; } = "";


    public override string ToString()
    {
        return $"content: {stringToFind}, Different Lower and higher case: {haveDifferentLowAndHighCase}, Count Line: {countLine}, Path: {path}";
    }
}
