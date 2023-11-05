//Uncomment method what you need

using FizzBuzzLibrary.Domain;
using FizzBuzzTests;

List<TokenMap> fizzBuzzTokens = new()
{
    new TokenMap()
    {
        Multiple = 7,
        Word ="Poem"
    },
    new TokenMap()
    {
        Multiple = 17,
        Word ="Writer"
    },
    new TokenMap()
    {
        Multiple = 3,
        Word ="College"
    }
};

List<int> numbers = new()
{
    3,15,26,73,54,-56,2,445,109,23,2,-43,22,119,51,21,357,-17,-3,-2,1
};
Console.WriteLine("Execution By Number Range");
FizzBuzzExecutor.ExecuteByNumberRange(-2, -37);
Console.WriteLine("Execution By non-sequential set of numbers");
FizzBuzzExecutor.ExecuteByArray(numbers);
Console.WriteLine("Execution By user tokens");
FizzBuzzExecutor.ExecuteByUserTokens(numbers, fizzBuzzTokens);
Console.WriteLine("Execution By API");
await FizzBuzzExecutor.ExecuteByApi(numbers, 4);




