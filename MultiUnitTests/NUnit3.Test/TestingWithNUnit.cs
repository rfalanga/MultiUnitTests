using SimpleDLL; // Ensure this namespace matches the one in your SimpleDLL project

namespace NUnit3.Test;

public class TestingWithNUnit
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAddingFour()
    {
        // Arrange
        var simple = new AddSomeIntegers(); // Replace SimpleDLL with the correct class name

        // Act
        var result = simple.AddFour(4);

        // Assert
        Assert.That(result, Is.EqualTo(8)); // Use Assert.That with Is.EqualTo
    }
}
