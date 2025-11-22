using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace TranslatorDataLayer
{
    public class clsDataAccessSettings
    {
        static string targetPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyTranslator", "TranslatorDB.mdf");

        public static string ConnentionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={targetPath};Integrated Security=True;Connect Timeout=30";
    }
}
