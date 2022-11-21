namespace BracketsTest
{
    [TestClass]
    public class BracketsTest
    {
        void Test(string str, bool result)
        {
            Assert.AreEqual(result, Program.IsCorrect(str));
        }
        [TestMethod]
        public void RightSequence()
        {
            Test("(([]))[]()", true);
        }
        [TestMethod]
        public void TooMuchOpeningBrackets()
        {
            Test("(()", false);
        }
        [TestMethod]
        public void TooMuchClosingBrackets()
        {
            Test("())", false);
        }
        [TestMethod]
        public void BracketsDoesNotMatch()
        {
            Test("[)", false);
        }
        [TestMethod]
        public void EmptyString()
        {
            Test("", true);
        }
        [TestMethod]
        public void WrongSymbols()
        {
            Test("ab", false);
        }
    }

}