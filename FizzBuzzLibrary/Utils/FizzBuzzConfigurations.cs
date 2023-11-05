using FizzBuzzLibrary.Domain;

namespace FizzBuzzLibrary.Utils
{
    //configuraciones de mulktiple y words de todos los ejemplos
    public static class FizzBuzzConfigurations
    {
        public static readonly List<TokenMap> fizzBuzzTokens = new ()
        {
            new TokenMap()
            {
                Multiple = 3,
                Word ="Fizz"
            },
            new TokenMap()
            {
                Multiple = 5,
                Word ="Buzz"
            }
        };
    }
}
