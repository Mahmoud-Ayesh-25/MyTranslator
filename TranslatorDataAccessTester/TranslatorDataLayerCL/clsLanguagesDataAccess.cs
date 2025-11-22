using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TranslatorDataLayer
{
    public class clsLanguagesDataAccess
    {
        static public DataTable GetAllLanguages()
        {
            DataTable LanguagesTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnentionString))
            {
                string quiry = "SELECT * FROM Languages ORDER BY LangName";

                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                LanguagesTable.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return LanguagesTable;
        }
    }
}
