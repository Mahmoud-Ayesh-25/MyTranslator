using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslatorDataLayer;

namespace TranslatorDataLayerCL
{
    public class clsTranslationHistoryDataAccess
    {
        public static DataTable GetAllTranslations()
        {
            DataTable TranslationsTable = new DataTable();

            string quiry = @"SELECT * FROM TranslationHistory ORDER BY TranslateDate DESC";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnentionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                TranslationsTable.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return TranslationsTable;
        }

        public static int AddNewTransation(string TranslateFrom, string TranslateTo, DateTime TranslationDate)
        {
            int TransationID = -1;

            string quiry = @"INSERT INTO TranslationHistory
                            VALUES
                            (
	                            @TranslateFrom,
	                            @TranslateTo,
	                            @TranslationDate
                            )
                            SELECT SCOPE_IDENTITY()";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnentionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    command.Parameters.AddWithValue("@TranslateFrom", TranslateFrom);
                    command.Parameters.AddWithValue("@TranslateTo", TranslateTo);
                    command.Parameters.AddWithValue("@TranslationDate", TranslationDate);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            TransationID = ID;
                        }
                    }
                    catch { }
                }
            }

            return TransationID;
        }

        public static bool DeleteTranslation(int TranslationID)
        {
            bool isDeleted = false;

            string quiry = @"DELETE FROM TranslationHistory
                            WHERE TranslationID = @TranlationID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnentionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(quiry,connection))
                {
                    command.Parameters.AddWithValue("@TranlationID", TranslationID);

                    try
                    {
                        int result = command.ExecuteNonQuery();

                        if (result >  0)
                        {
                            isDeleted = true;
                        }
                    }
                    catch {}
                }
            }

            return isDeleted;
        }

        public static void ClearTranslationHistory()
        {
            string quiry = "TRUNCATE TABLE TranslationHistory;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnentionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
