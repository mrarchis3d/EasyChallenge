using FizzBuzzLibrary.Domain;
using FizzBuzzLibrary.Services;
using FizzBuzzLibrary.Utils;

namespace FizzBuzzTests;

public static class FizzBuzzExecutor
{
    public static async Task ExecuteByApi(List<int> numbers, int numberTokens)
    {
        FizzBuzzService fb = new FizzBuzzService();

        List<TokenMap> tokenMap = await fb.GetRandomTokens(numberTokens);

        OutputConsole.PrintTokens(tokenMap);
        var result = fb.GetFizzBuzzByList(numbers, tokenMap);
        OutputConsole.PrintResult(result);
    }

    public static void ExecuteByUserTokens(List<int> numbers, List<TokenMap> tokens)
    {
        FizzBuzzService fb = new FizzBuzzService();
        OutputConsole.PrintTokens(tokens);
        var result = fb.GetFizzBuzzByList(numbers, tokens);
        OutputConsole.PrintResult(result);
    }

    public static void ExecuteByNumberRange(int init, int end)
    {
        FizzBuzzService fb = new FizzBuzzService();

        List<TokenMap> tokenMap = FizzBuzzConfigurations.fizzBuzzTokens;
        OutputConsole.PrintTokens(tokenMap);
        var result = fb.FizzBuszzByNumberRange(init, end, tokenMap);
        OutputConsole.PrintResult(result);
    }

    public static void ExecuteByArray(List<int> numbers)
    {
        FizzBuzzService fb = new FizzBuzzService();

        List<TokenMap> tokenMap = FizzBuzzConfigurations.fizzBuzzTokens;
        OutputConsole.PrintTokens(tokenMap);
        var result = fb.GetFizzBuzzByList(numbers, tokenMap);
        OutputConsole.PrintResult(result);
    }
}
