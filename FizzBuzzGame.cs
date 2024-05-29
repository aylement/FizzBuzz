namespace FizzBuzz;
public static class FizzBuzzGame
{
    public static string Play(int number) =>
     number switch
     {
         _ when number.IsDivisibleBy(15)
         => "FizzBuzz",
         _ when number.IsDivisibleBy(3)
         => "Fizz",
         _ when number.IsDivisibleBy(5)
         => "Buzz",
         _ => number.ToString()
     };
    private static bool IsDivisibleBy(this int i, int divisibleBy)
   => i % divisibleBy == 0;
    /// <summary>
    /// Returns first part of number.
    /// </summary>
    /// <param name="number">Initial number</param>
    /// <param name="N">Amount of digits required</param>
    /// <returns>First part of number</returns>
    private static int TakeNDigits(int number, int N)
    {
        // this is for handling negative numbers, we are only insterested in postitve number
        number = Math.Abs(number);
        // special case for 0 as Log of 0 would be infinity
        if (number == 0)
            return number;
        // getting number of digits on this input number
        int numberOfDigits = (int)Math.Floor(Math.Log10(number) + 1);
        // check if input number has more digits than the required get first N digits
        if (numberOfDigits >= N)
            return (int)Math.Truncate((number / Math.Pow(10, numberOfDigits - N)));
        else
            return number;
    }
    public static bool InitialCheck(string field, out string? result, out int inputFizzBuzz)
    {
        //inputFizzBuzz = 0;
        result = "";
        if(!int.TryParse(field, out inputFizzBuzz))
        {
            result = "Please enter a number.";
            return true;
        }
        return false;
    }
}