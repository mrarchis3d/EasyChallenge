using FizzBuzzLibrary.Domain;
using System.Text;

namespace FizzBuzzLibrary.Utils
{
    public static class FizzBuzzProcess
    {
        public static string GetFizzBuzz(int number, List<TokenMap>? tokens = null)
        {
            StringBuilder sb = new StringBuilder();
            if (tokens == null)
            {
                tokens = FizzBuzzConfigurations.fizzBuzzTokens;
            }
            foreach (var item in tokens)
            {
                if (number % item.Multiple == 0)
                {
                    sb.Append(item.Word);
                }
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
                return sb.ToString();
            else
                return number.ToString();
        }
    }
}
