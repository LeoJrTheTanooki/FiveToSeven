namespace FiveToSeven.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{

    public string OddOrEven(string num)
    {
        
        int trueNum = 0;
        bool numCheck = Int32.TryParse(num, out trueNum);
        if (numCheck)
        {
            if (trueNum % 2 == 0)
            {
                return $"{num} is an even number";
            }
            return $"{num} is an odd number";
        }
        return "This is not a number";
    }

}


