namespace FiveToSeven.Services.OddOrEven;

    public class OddOrEvenService : IOddOrEvenService
    {
        public string OddOrEven(int num)
        {
            if (num % 2 == 0)
            {
                return $"{num} is an even number";
            }
            return $"{num} is an odd number";
        }
        
    }

    
