namespace xUnit.Test
{
    public class TestingWithXUnit
    {
        [Fact]
        public void TestAddingTwo()
        {             
            int a = 1;
            int b = 2;
            int result = a + b;
            Assert.Equal(3, result);
        }
    }
}
