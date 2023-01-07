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
            string testString4 = null;

            Assert.Equal(0,lh.findLength(testString1));   // ""
            Assert.Equal(3, lh.findLength(testString2));  // "123"
            Assert.Equal(1, lh.findLength(testString3)); // "123456789010"
            Assert.Equal(1, lh.findLength(testString4));  // null
            

        }
    }
}