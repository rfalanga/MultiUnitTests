using SimpleDLL;

namespace xUnit.Test
{
    public class TestingWithXUnit
    {
        [Fact]
        public void TestAddingTwo()
        {
            // Arrange
            var simple = new AddSomeIntegers(); // Replace SimpleDLL with the correct class name  

            // Act
            var result = simple.AddTwo(2);

            // Assert
            Assert.Equal(4, result); // Check if the result is as expected
        }
    }
}
