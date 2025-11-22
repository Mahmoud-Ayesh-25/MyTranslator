using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslatorBusinessLayer;
using TranslatorBusinessLayerCL;

namespace TranslatePresentaionLayer
{
    internal class Program
    {
        static void GetAllTranslations()
        {
            DataTable dataTable = clsTranslationsHistoryBusiness.GetAllTranslations();

            foreach(DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row[0]}, {row[1]}, {row[2]}, {row[3]}, {row[4]}");
            }
        }

        static void AddNewTranslation()
        {
            clsTranslationsHistoryBusiness Translation = new clsTranslationsHistoryBusiness();

            Translation.LanguageID = 546;
            Translation.TranslateFrom = "fadashfkhsdakjfhlksahlfjhl";
            Translation.TranslateTo = "fadashfkhsdakjfhlksahlfjhl";
            Translation.TranslationDate = DateTime.Now;

            if (Translation.AddNewTransation())
            {
                Console.WriteLine($"Translation added successfully, and the TranslationID = {Translation.TranslationID}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        static void Main(string[] args)
        {
            AddNewTranslation();
        }
    }
}
