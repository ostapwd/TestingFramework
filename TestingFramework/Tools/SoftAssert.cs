using System.Text;
using NUnit.Framework;

namespace AlphadasAT.Tools
{
    public class SoftAssert
    {
        private readonly StringBuilder _messages;

        private bool _status = true;

        public SoftAssert()
        {
            _messages = new StringBuilder();
        }

        public void IsTrue(bool condition, string message)
        {
            try
            {
                Assert.IsTrue(condition, message);
            }
            catch (AssertionException exception)
            {
                _status = false;
                _messages.Append(exception.Message).AppendLine();
            }
        }

        public void IsFalse(bool condition, string message)
        {
            try
            {
                Assert.IsFalse(condition, message);
            }
            catch (AssertionException exception)
            {
                _status = false;
                _messages.Append(exception.Message).AppendLine();
            }
        }

        public void AreEqual(string expected, string actual, string message)
        {
            try
            {
                Assert.AreEqual(expected, actual, message);
            }
            catch (AssertionException exception)
            {
                _status = false;
                _messages.Append(exception.Message).AppendLine();
            }
        }

        public void AreEqual(int expected, int actual, string message)
        {
            try
            {
                Assert.AreEqual(expected, actual, message);
            }
            catch (AssertionException exception)
            {
                _status = false;
                _messages.Append(exception.Message).AppendLine();
            }
        }

        public void AreEqual(bool expected, bool actual, string message)
        {
            try
            {
                Assert.AreEqual(expected, actual, message);
            }
            catch (AssertionException exception)
            {
                _status = false;
                _messages.Append(exception.Message).AppendLine();
            }
        }

        public void AssertAll()
        {
            try
            {
                Assert.True(_status);
            }
            catch (AssertionException exception)
            {
                throw new AssertionException(_messages.ToString());
            }
        }
    }
}