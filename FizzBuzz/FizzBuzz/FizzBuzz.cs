namespace FizzBuzz
{
    class FizzBuzz
    {
        private readonly FizzBuzzIo _fizzBuzzIo;
        private readonly FizzBuzzFunctions _fizzBuzzFunctions;

        public FizzBuzz(FizzBuzzIo fizzBuzzIo, FizzBuzzFunctions fizzBuzzFunctions)
        {
            _fizzBuzzIo = fizzBuzzIo;
            _fizzBuzzFunctions = fizzBuzzFunctions;
        }

        public void Run()
        {
            bool playAgain;
            do
            {
                int userInput = _fizzBuzzIo.EnterANumber();
                var results = _fizzBuzzFunctions.CalculateFizzBuzzUpTo(userInput);

                foreach (var item in results)
                {
                    _fizzBuzzIo.WriteFizzBuzz(item);
                }
                playAgain = _fizzBuzzIo.PlayAgain();
            } while (playAgain);
        }
    }
}
