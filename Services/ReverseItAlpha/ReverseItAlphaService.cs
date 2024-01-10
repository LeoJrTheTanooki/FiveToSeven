namespace FiveToSeven.Services.ReverseItAlpha;

public class ReverseItAlphaService : IReverseItAlphaService
{
    public string ReverseItA(string word)
    {
        string result = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            result += word[i];
        }
        return $"{word} reversed is {result}";
    }
}
