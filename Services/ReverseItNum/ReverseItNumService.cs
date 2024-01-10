namespace FiveToSeven.Services.ReverseItNum;

public class ReverseItNumService : IReverseItNumService
{
    public int ReverseItB(int num)
    {
        string numString = num.ToString();
        string resultString = "";
        for (int i = numString.Length - 1; i >= 0; i--)
        {
            resultString += numString[i];
        }
        int result = int.Parse(resultString);
        return result;
    }

}
