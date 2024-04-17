using System;
using NUnit.Framework;

namespace unitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Login_Accessor_retreives_customer1()
        {
            LoginAccessor login1 = new LoginAccessor();
            Assert.AreEqual(1, login1.accessLoginInformation("JamalMCA", "Password1"));
        }

        [Test]
        public void Login_Accessor_retreives_customer2()
        {
            LoginAccessor login2 = new LoginAccessor();
            Assert.AreEqual(2, login2.accessLoginInformation("Camel", "Password2"));
        }

        [Test]
        public void Login_Accessor_retreives_customer2_wrong_customerId()
        {
            LoginAccessor login3 = new LoginAccessor();
            Assert.AreNotEqual(1, login3.accessLoginInformation("Camel", "Password2"));
        }

        [Test]
        public void Login_Accessor_returns_null_for_customer_not_in_system()
        {
            LoginAccessor login4 = new LoginAccessor();
            Assert.AreEqual(-1, login4.accessLoginInformation("Ronnie", "Green"));
        }
    }
}