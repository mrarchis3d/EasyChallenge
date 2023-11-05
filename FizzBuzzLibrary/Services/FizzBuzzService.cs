using FizzBuzzLibrary.Domain;
using FizzBuzzLibrary.Utils;
using System.Text.Json;

namespace FizzBuzzLibrary.Services;

public class FizzBuzzService
{

    /// <summary>
    /// Accept user input for a range of numbers and returns their FizzBuzz output. For example, 1-50, 1-2,000,000,000, or (-2)-(-37)
    /// </summary>
    /// <param name="init"></param>
    /// <param name="end"></param>
    /// <param name="tokens"></param>
    /// <returns></returns>
    public List<string> FizzBuszzByNumberRange(int init, int end, List<TokenMap> tokens)
    {
        List<string> fizzBuzzList = new();
        int step = init <= end ? 1 : -1;
        if (step == -1)
        {
            for (int i = init; i >= end; i += step)
            {
                fizzBuzzList.Add(FizzBuzzProcess.GetFizzBuzz(i, tokens));
            }
        }
        else
        {
            for (int i = init; i <= end; i += step)
            {
                fizzBuzzList.Add(FizzBuzzProcess.GetFizzBuzz(i, tokens));
            }
        }
        return fizzBuzzList;
    }

    /// <summary>
    /// Get Fizz Buzz from List of numbers
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="tokens">Accept user input for alternative tokens instead of "Fizz" and "Buzz" and alternative divisors 
    /// instead of 3 and 5. For example, 7, 17, and 3 would use "Poem", "Writer", and "College".</param>
    /// <returns></returns>
    public List<string> GetFizzBuzzByList(List<int> numbers, List<TokenMap>? tokens = null)
    {
        List<string> fizzBuzzList = new();
        foreach (int number in numbers)
        {
            fizzBuzzList.Add(FizzBuzzProcess.GetFizzBuzz(number, tokens));
        }
        return fizzBuzzList;
    }
    /// <summary>
    /// Accept user input for API generated tokens provided by [https://rich-red-cocoon-veil.cyclic.app/]
    /// </summary>
    /// <param name="numberOfTokens"></param>
    /// <returns></returns>
    public async Task<List<TokenMap>> GetRandomTokens(int numberOfTokens)
    {
        List<TokenMap> tokens = new List<TokenMap>();
        for (int i = 0; i < numberOfTokens; i++)
        {
            tokens.Add(await GetFromUrl());
        }
        return tokens;

    }

    private async Task<TokenMap> GetFromUrl()
    {
        HttpService httpService = new HttpService();
        var response = await httpService.GetAsync("https://rich-red-cocoon-veil.cyclic.app/random");
        var randomData = JsonSerializer.Deserialize<TokenMap>(response);
        if (randomData != null)
            return randomData;
        throw new Exception("Something goes wrong with the server, please try another method.");
    }


}
