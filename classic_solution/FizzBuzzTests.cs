 [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        [TestInitialize]
        public void Init()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void WhenParsingOne_ReturnOne()
        {
            string result = _fizzBuzz.Parse(1);

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void WhenParsingTwo_ReturnTwo()
        {
            string result = _fizzBuzz.Parse(2);

            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void WhenParsingThree_ReturnFizz()
        {
            string result = _fizzBuzz.Parse(3);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void WhenParsingSix_ReturnFizz()
        {
            string result = _fizzBuzz.Parse(6);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void WhenParsingFive_ReturnBuzz()
        {
            string result = _fizzBuzz.Parse(5);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void WhenParsingTen_ReturnBuzz()
        {
            string result = _fizzBuzz.Parse(10);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void WhenParsingEight_ReturnEight()
        {
            string result = _fizzBuzz.Parse(8);

            Assert.AreEqual("8", result);
        }

        [TestMethod]
        public void WhenParsingFifteen_ReturnFizzBuzz()
        {
            string result = _fizzBuzz.Parse(15);

            Assert.AreEqual("FizzBuzz", result);
        }
    }