using HelloTest;
namespace Testing_Hello;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test1()
    {
         //Tripple AAA Arrange, Act, Assert

            //Arrange -create instances, set input
            var helloTest = new HelloTesting();

            //Act -call the relevant methods
            var result = helloTest.Greet();

            //Assert - confirm if the results are what is expected
            Assert.IsTrue(result =="Hello test");
    }
}