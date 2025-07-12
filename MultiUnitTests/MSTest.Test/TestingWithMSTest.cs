using SimpleDLL; // Ensure this namespace matches the one in your SimpleDLL project

namespace MSTest.Test;

[TestClass]
public sealed class TestingWithMSTest
{
    [TestMethod]
    public void TestAddingThree()
    {
        // Arrange
        var simple = new AddSomeIntegers(); // Replace SimpleDLL with the correct class name

        // Act
        var result = simple.AddThree(3);

        // Assert
        Assert.AreEqual(6, result); // Check if the result is as expected
    }
}
