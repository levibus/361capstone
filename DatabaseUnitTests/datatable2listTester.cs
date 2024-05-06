using System.Data;
using System;
using _361capstone.Models;

namespace DatabaseUnitTests
{
    [TestClass]
    public class datatable2listTester
    {
        [TestMethod]
        public void datatable_conversion_to_list_test()
        {
            // Arranger
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("firstName", typeof(string));
            table.Columns.Add("lastName", typeof(string));
            table.Columns.Add("username", typeof(string));
            table.Columns.Add("password", typeof(string));

            var row1 = table.NewRow();
            row1["Id"] = 1;
            row1["firstName"] = "Jamal";
            row1["lastName"] = "McAdams";
            row1["username"] = "JamalMCA";
            row1["password"] = "password1";
            table.Rows.Add(row1);

            var row2 = table.NewRow();
            row2["Id"] = 2;
            row2["firstName"] = "Kamel";
            row1["lastName"] = "Noah";
            row1["username"] = "Camel";
            row1["password"] = "password2";
            table.Rows.Add(row2);

            // Expected List
            var expectedList = new List<testCustomer>
            //List<string> expectedList = new List<string>();
            {
                new testCustomer { Id = 1, firstName = "Jamal", lastName = "McAdams", username = "JamalMCA", password = "password1"},
                new testCustomer { Id = 2, firstName = "Kamel", lastName = "Noah", username = "Camel", password = "password2"}
            };

            // Act
            var resultList = datatable2list.ConvertDataTableToList<testCustomer>(table);

            // Assert
            Assert.AreEqual(expectedList.Count, resultList.Count);
            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i].Id, resultList[i].Id);
                Assert.AreEqual(expectedList[i].firstName, resultList[i].firstName);
            }
        }
        public class testCustomer
        {
            public int Id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string username { get; set; }
            public string password { get; set; }

        }

    }
}