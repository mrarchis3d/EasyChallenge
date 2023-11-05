using FizzBuzzLibrary.Domain;
using FizzBuzzLibrary.Services;
using FizzBuzzLibrary.Utils;


List<TokenMap> tokenMap = new()
{
    new TokenMap()
    {
        Multiple = 5,
        Word ="Fizz"
    },
    new TokenMap()
    {
        Multiple = 9,
        Word ="Buzz"
    },
    new TokenMap()
    {
        Multiple = 27,
        Word ="Bar"
    }
};

FizzBuzzService fb = new FizzBuzzService();
OutputConsole.PrintTokens(tokenMap);
var result = fb.FizzBuszzByNumberRange(-20, 127, tokenMap);
OutputConsole.PrintResult(result);