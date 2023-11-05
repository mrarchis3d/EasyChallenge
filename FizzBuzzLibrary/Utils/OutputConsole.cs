
using FizzBuzzLibrary.Domain;

namespace FizzBuzzLibrary.Utils
{
    public static class OutputConsole
    {
        public static void PrintResult(List<string> result)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("HERE is your Result: ");
            result.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("---------------------------------------------------");
        }

        public static void PrintTokens(List<TokenMap> tokens)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("HERE are the tokens: ");
            tokens.ForEach(x => Console.WriteLine($"multiple '{x.Multiple}', word '{x.Word}'"));
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
