namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzFunctions = new FizzBuzzFunctions();
            var fizzBuzzIo = new FizzBuzzIo();

            var fizzBuzz = new FizzBuzz(fizzBuzzIo, fizzBuzzFunctions);

            fizzBuzz.Run();
        }
    }
}
