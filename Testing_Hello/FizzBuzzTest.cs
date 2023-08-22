using HelloTest;



namespace Testing_Hello{
    [TestFixture]
    public class FizzBuzzTest{

        private FizzBuzz fb;
        [SetUp]
        public void SetUp(){
             fb = new FizzBuzz();
        }
        [Test]
        public void Print_IfDivisible_ByBoth3and5_ReturnFizzBuzz(){
           

            var result = fb.Print(15);

            Assert.That (result =="FizzBuzz");
        }
        [Test]
        public void Print_IfDivisible_ByBoth5_ReturnBuzz(){

            var result = fb.Print(10);

            Assert.That(result == "Buzz");
        }

        [Test]
         public void Print_IfDivisible_ByBoth3_ReturnFizz(){
            
            var result = fb.Print(21);

            Assert.That(result == "Fizz");
        }

         [Test]
         public void Print_IfNotDivisible_ByBoth3and5_ReturnTheNumber(){
            
            var result = fb.Print(11);

            Assert.That(result == "11");
        }


        //Parameterized test
        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(50, "Buzz")]
        [TestCase(60, "FizzBuzz")]
        [TestCase(13, "13")]

        public void Print_WhenCalledWithDifferentInputs_ReturnTheRelevantString(int input, string outcome){
            var result = fb.Print(input);
            Assert.That(result == outcome);
        }
    }
}