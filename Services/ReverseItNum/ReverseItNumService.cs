namespace FiveToSeven.Services.ReverseItNum;

public class ReverseItNumService : IReverseItNumService
{
    public string ReverseItB(string num)
    {
        // Previous Code
        // string numString = num.ToString();
        // string resultString = "";
        // for (int i = numString.Length - 1; i >= 0; i--)
        // {
        //     resultString += numString[i];
        // }
        // int result = int.Parse(resultString);
        // return result;
        // Replace all instances of string num to int num for IReverseItNumServices and ReverseItNumController to make service work properly

        int trueNum = 0;
        bool numCheck = Int32.TryParse(num, out trueNum);
        if (numCheck)
        {
            string numString = num.ToString();
            string resultString = "";
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                resultString += numString[i];
            }
            int result = int.Parse(resultString);
            return $"{num} reversed is {result}";
        }
        return "This is not a number";
    }

}
