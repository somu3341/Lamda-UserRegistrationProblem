using UserRegistartion;

namespace UserNunitTest
{
    public class Tests
    {
        [Test]
        public void GivenUserFirstName_WhenAnalyze_ReturnValid()
        {
            string first = "Soma";
            User user = new User(first);
            string result = user.UserFirst();
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserFirstName_WhenAnalyze_ReturnInValid()
        {
            try
            {
                string first = "soma";
                User user = new User(first);
                string result = user.UserFirst();
                Assert.AreEqual(result, "InValid");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "InValid");
            }
        }
        [Test]
        public void GivenUserLastName_WhenAnalyze_ReturnValid()
        {
            string Last = "Shekar";
            User user = new User(Last);
            string result = user.UserFirst();
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserLastName_WhenAnalyze_ReturnInValid()
        {
            try
            {
                string Last = "shekar";
                User user = new User(Last);
                string result = user.UserFirst();
                Assert.AreEqual(result, "InValid");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "InValid");
            }
        }
        [Test]
        public void GivenUserEmail_WhenAnalyze_ReturnValid()
        {
            string Email = "abc.xyz@bl.co.in";
            User user = new User(Email);
            string result = user.Email();
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserEmail_WhenAnalyze_ReturnInValid()
        {
            try
            {
                string Email = "abc.xyz.@bl.co.in";
                User user = new User(Email);
                string result = user.Email();
                Assert.AreEqual(result, "InValid");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "InValid");
            }
        }
        [Test]
        public void GivenUserMobileNumber_WhenAnalyze_ReturnValid()
        {
            string mobile = "91 9919819801";
            User user = new User(mobile);
            string result = user.Mobile();
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserMobileNumber_WhenAnalyze_ReturnInValid()
        {
            try
            {
                string mobile = "919919819801";
                User user = new User(mobile);
                string result = user.Mobile();
                Assert.AreEqual(result, "InValid");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "InValid");
            }
        }
        [Test]
        public void GivenUserPasswordRule4_WhenAnalyze_ReturnValid()
        {
            string pass = "SOmu@12323";
            User user = new User(pass);
            string result = user.Password();
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserPasswordRule4_WhenAnalyze_ReturnInValid()
        {
            try
            {
                string pass = "SOmu@";
                User user = new User(pass);
                string result = user.Password();
                Assert.AreEqual(result, "InValid");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "InValid");
            }
        }
    }
}