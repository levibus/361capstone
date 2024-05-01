//namespace _361capstone;

//public class PullProductByCategory
//{
//    public int accessProductByCategory(int categoryCode)
//    {
//        object categoryCodeReturn = -1;
//        string query = "SELECT * FROM PRODUCT WHERE categoryCode = @categoryCode ";

//        using (SqlConnection conn = new SqlConnection())
//        {
//            conn.ConnectionString = "Server=DESKTOP-QEQG0AR;Database=master;Trusted_Connection=true";
//            try
//            {
//                conn.Open();
//            }
//            catch
//            {
//                return -2; // error in connection
//            }

//            using (SqlCommand command = new SqlCommand(query, conn))
//            {
//                command.Parameters.AddWithValue("@categoryCode", categoryCode);

//                categoryCodeReturn = command.ExecuteScalar();
//                if (categoryCodeReturn == null)
//                {
//                    categoryCodeReturn = -1; // customer not found
//                }

//            }
//            conn.Close();
//        }
//        return (int)categoryCodeReturn;
//    }
//}