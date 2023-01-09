using LearnConsoleApp;
using Xunit;

namespace FindStringLength
{
    public class UnitTest1
    {
        [Fact]
        public void testCases()
        {
            LengthHelper lh = new LengthHelper();

            string testString1 = "";
            string testString2 = "123";
            string testString3 = "123456789010";

            Assert.Equal(0,lh.findLength(testString1));   // ""
            Assert.Equal(3, lh.findLength(testString2));  // "123"
            Assert.Equal(12, lh.findLength(testString3)); // "123456789010"
            
        }

        [Fact]
        public void testNullString()
        {
            LengthHelper lh1 = new LengthHelper();
            string testString = null;
            var error  = Assert.Throws<ArgumentException>(()=> lh1.findLength(testString));
            Assert.Equal("string passed cannot be null", error.Message);
        }
    }
}