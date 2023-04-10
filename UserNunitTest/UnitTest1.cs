using UserRegistartion;

namespace UserNunitTest
{
    public class Tests
    {
        [Test]
        public void GivenUserFirstName_WhenAnalyze_ReturnValid()
        {
            string first = "Soma";
            User user = new User();
            string result = user.UserFirst(first);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserLastName_WhenAnalyze_ReturnValid()
        {
            string Last = "Shekar";
            User user = new User();
            string result = user.UserFirst(Last);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserEmail_WhenAnalyze_ReturnValid()
        {
            string Email = "abc.xyz@bl.co.in";
            User user = new User();
            string result = user.Email(Email);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserMobileNumber_WhenAnalyze_ReturnValid()
        {
            string mobile = "91 9919819801";
            User user = new User();
            string result = user.Mobile(mobile);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserPasswordRule4_WhenAnalyze_ReturnValid()
        {
            string pass = "SOmu@2733";
            User user = new User();
            string result = user.Password(pass);
            Assert.AreEqual(result, "Valid");
        }
    }
}