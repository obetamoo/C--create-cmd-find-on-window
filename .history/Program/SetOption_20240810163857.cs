using System;

namespace Program;

public class SetOption
{
    public string content { get; set; } = "";
    public bool haveDifferentLowAndHighCase { get; set; } = true;
    public bool countLine { get; set; } = false;

    public string path { get; set; } = "";

    public override string ToString()
    {
        return $"";
    }
}
