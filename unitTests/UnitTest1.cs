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
    }
}