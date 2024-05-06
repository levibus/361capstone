namespace LoginUnitTests
{
    [TestClass]
    public class LoginAccessorTester
    {
        [TestMethod]
        public void Login_Accessor_retreives_customer1()
        {
            var LoginAccessor = new LoginAccessor();
            Assert.AreEqual(1, LoginAccessor.accessLoginInformation("JamalMCA", "Password1"));
        }

        [TestMethod]
        public void Login_Accessor_retreives_customer2()
        {
            var LoginAccessor = new LoginAccessor();
            Assert.AreEqual(2, LoginAccessor.accessLoginInformation("Camel", "Password2"));
        }

        [TestMethod]
        public void Login_Accessor_retreives_customer2_wrong_customerId()
        {
            var LoginAccessor = new LoginAccessor();
            Assert.AreNotEqual(1, LoginAccessor.accessLoginInformation("Camel", "Password2"));
        }

        [TestMethod]
        public void Login_Accessor_returns_null_for_customer_not_in_system()
        {
            var LoginAccessor = new LoginAccessor();
            Assert.AreEqual(-1, LoginAccessor.accessLoginInformation("Ronnie", "Green"));
        }


    }
}