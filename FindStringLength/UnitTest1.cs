using LearnConsoleApp;
namespace FindStringLength
{
    public class UnitTest1
    {
        [Fact]
        public void checkLength()
        {
            LearnHelper lh = new LearnHelper();
            string example = "Test String";
            Assert.Equal(example.Length,lh.findLength(example));
        }
    }
}