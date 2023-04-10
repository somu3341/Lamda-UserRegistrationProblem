using UserRegistartion;

namespace UserNunitTest
{
    public class Tests
    {
        [Test]
        public void GivenUserFirstName_WhenAnalyze_ReturnValid()
        {
            string first = "soma";
            User user = new User(first);
            string result = user.UserFirst();
            Assert.AreEqual(result, "InValid");
        }
        [Test]
        public void GivenUserLastName_WhenAnalyze_ReturnValid()
        {
            string Last = "shekar";
            User user = new User(Last);
            string result = user.UserFirst();
            Assert.AreEqual(result, "InValid");
        }
        [Test]
        public void GivenUserEmail_WhenAnalyze_ReturnValid()
        {
            string Email = "abc.xyz.@bl.co.in";
            User user = new User(Email);
            string result = user.Email();
            Assert.AreEqual(result, "InValid");
        }
        [Test]
        public void GivenUserMobileNumber_WhenAnalyze_ReturnValid()
        {
            string mobile = "919919819801";
            User user = new User(mobile);
            string result = user.Mobile();
            Assert.AreEqual(result, "InValid");
        }
        [Test]
        public void GivenUserPasswordRule4_WhenAnalyze_ReturnValid()
        {
            string pass = "SOmu@";
            User user = new User(pass);
            string result = user.Password();
            Assert.AreEqual(result, "InValid");
        }           
    }
}