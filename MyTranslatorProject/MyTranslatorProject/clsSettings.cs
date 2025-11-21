using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTranslatorProject
{
    public class clsSettings
    {
        private const int MOD_ALT = 0x1;
        private const int MOD_CONTROL = 0x2;
        private const int MOD_SHIFT = 0x4;

        static public MyTranslator MainForm;

        static public Keys ExtractKey(string key)
        {
            return (Keys)Enum.Parse(typeof(Keys), key, true);
        }
        static public int ExtractMOD(string stMOD)
        {
            switch (stMOD)
            {
                case "MOD_ALT":
                    return MOD_ALT;
                case "MOD_CONTROL":
                    return MOD_CONTROL;
                case "MOD_SHIFT":
                    return MOD_SHIFT;
                default: return MOD_ALT;
            }
        }
    }
}
