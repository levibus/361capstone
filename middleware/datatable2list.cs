using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

public class datatable2list
{
    public static List<T> ConvertDataTableToList<T>(DataTable dataTable) where T : new()
    {
        List<T> list = new List<T>();

        foreach (DataRow row in dataTable.Rows)
        {
            T obj = new T();

            foreach (DataColumn col in dataTable.Columns)
            {
                // Get the property with the same name as the column
                var property = typeof(T).GetProperty(col.ColumnName);
                if (property != null && row[col] != DBNull.Value)
                {
                    // Convert the value to the property type and set it
                    property.SetValue(obj, Convert.ChangeType(row[col], property.PropertyType));
                }
            }

            list.Add(obj);
        }

        return list;
    }
}