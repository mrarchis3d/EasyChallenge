using FizzBuzzLibrary.Services;

namespace IntegrationTests
{
    public class Tests
    {
        private FizzBuzzService _fizzBuzz; 
        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzzService();
        }

        [Test]
        public void Test1()
        {

        }
    }
}