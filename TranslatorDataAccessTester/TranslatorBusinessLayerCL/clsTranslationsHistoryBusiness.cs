using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslatorDataLayerCL;

namespace TranslatorBusinessLayerCL
{
    public class clsTranslationsHistoryBusiness
    {
        public int TranslationID { get; set; }
        public string TranslateFrom { get; set; }
        public string TranslateTo { get; set; }
        public DateTime TranslationDate { get; set; }

        public clsTranslationsHistoryBusiness()
        {
            TranslationID = -1;
            TranslateFrom = "";
            TranslateTo = "";
            TranslationDate = DateTime.Now;
        }

        public static DataTable GetAllTranslations()
        {
            return clsTranslationHistoryDataAccess.GetAllTranslations();
        }

        public bool AddNewTransation()
        {
            int TranslationID = clsTranslationHistoryDataAccess.AddNewTransation(TranslateFrom, TranslateTo, TranslationDate);
            this.TranslationID = TranslationID;
            return (TranslationID != -1);
        }

        public static bool DeleteTranslation(int TranslationID)
        {
            return clsTranslationHistoryDataAccess.DeleteTranslation(TranslationID);
        }

        public static void ClearTranslationHistory()
        {
            clsTranslationHistoryDataAccess.ClearTranslationHistory();
        }
    }
}
