using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookingcom
{
    public static class SQLClass
    {
        public const string CONNECTION_STRING =
            "SslMode=none; Server=localhost; Database=restoran; port=3306;Uid=root;";
        public static MySqlConnection conn;
        // <summary>
        // функция SELECT-запроса
        // </summary>

        public static List<string> MySelect(string cmdText)
        {
            List<String> list = new List<string>();


            MySqlCommand cmd1 = new MySqlCommand(cmdText, conn);
            DbDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {

                    list.Add(reader.GetString(i));

                }

            }
            reader.Close();
            return list;
        }


    }
}
