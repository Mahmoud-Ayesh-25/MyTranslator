using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TranslatorDataLayer;

namespace TranslatorBusinessLayer
{
    public class clsLanguageBusiness
    {
        static public DataTable GetAllLanguages()
        {
            return clsLanguagesDataAccess.GetAllLanguages();
        }
    }
}
