#region code
Console.Clear();
Welcome();
#endregion

#region methods
void Welcome()
{
    Console.Write("Please enter the text you want to check: ");
    string text = Console.ReadLine()!;
    Console.Write("Please enter what you want to check: ");
    string methodToDo = Console.ReadLine()!.ToLower();
    CheckWhichMethod(methodToDo, text);
}
void CheckWhichMethod(string identifier, string text)
{
    switch (identifier)
    {
        case "contains":
        case "indexof":
        case "lastindexof":
            Console.Write("Which Character do you want me to search for? ");
            char searchForIndex = char.Parse(Console.ReadLine()!);
            switch (identifier)
            {
                case "contains": Console.WriteLine(Contains(text, searchForIndex)); break;
                case "indexof": Console.WriteLine(IndexOf(text, searchForIndex)); break;
                case "lastindexof": Console.WriteLine(LastIndexOf(text, searchForIndex)); break;
            }
            break;
        case "trimstart":
        case "trimend":
        case "trim" :
            Console.Write("Which Character do you want me to search for? ");
            char searchForTrim = char.Parse(Console.ReadLine()!);
            switch (identifier)
            {
                case "trimstart": Console.WriteLine(TrimStart(ref text, searchForTrim)); break;
                case "trimend": Console.WriteLine(TrimEnd(ref text, searchForTrim)); break;
                case "trim": Console.WriteLine(Trim(text, searchForTrim)); break;
            }
            break;
        case "substring": 
            Console.Write("Please enter the Index and the max length: ");
            int index = int.Parse(Console.ReadLine()!);
            int maxLength = int.Parse(Console.ReadLine()!);
            Console.WriteLine(SubString(text, index, maxLength));
            break;
    }
}
bool Contains(string text, char searchFor)
{
    for (int i = 0; i < text.Length; i++)
    {
        char text2 = text[i];
        if (text2 == searchFor) { return true; }
    }
    return false;
}
int IndexOf(string text, char searchFor)
{
    if (!Contains(text, searchFor)) { return -1; }
    else
    {
        for (int i = 0; i < text.Length; i++)
        {
            char text2 = text[i];
            if (text2 == searchFor) { return i; }
        }
    }
    return -1;
}
int LastIndexOf(string text, char searchFor)
{
    if (!Contains(text, searchFor)) { return -1; }
    else
    {
        for (int i = (text.Length - 1); i > 0; i--)
        {
            char text2 = text[i];
            if (text2 == searchFor) { return i; }
        }
    }
    return -1;
}
string TrimStart(ref string text, char trim)
{
    for (int i = 0; i < text.Length;)
    {
        if (text[i] != trim)
        {
            return text;
        }
        else
        {
            text = text[(i + 1)..];
        }
    }
    return text;
}
string TrimEnd(ref string text, char trim)
{
    for (int i = (text.Length - 1); i >= 0; i--)
    {
        if (text[i] != trim)
        {
            return text;
        }
        else
        {
            text = text[..i];
        }
    }
    return text;
}
string Trim(string text, char trim)
{
    TrimStart(ref text, trim);
    TrimEnd(ref text, trim);
    return text;
}
string SubString(string text, int startIndex, int maxLength)
{
    string substring = "";
    for (int i = startIndex; i - startIndex < maxLength; i++)
    {
        if (i < text.Length)
        {
            substring += text[i];
        }
    }
    return substring;
}
#endregion