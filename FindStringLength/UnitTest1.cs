using LearnConsoleApp;
namespace FindStringLength
{
    public class UnitTest1
    {
        [Fact]
        public void checkLength()
        {
            LengthHelper lh = new LengthHelper();
            string example = "Test String";
            Assert.Equal(example.Length,lh.findLength(example));
        }
    }
}