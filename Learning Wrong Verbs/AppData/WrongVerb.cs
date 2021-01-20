using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Wrong_Verbs.AppData
{
    public class WrongVerb
    {
        public WrongVerb(string translation, string fform, string sform, string tform, bool right = false)
        {
            this.Translation = translation;
            this.FForm = fform;
            this.SForm = sform;
            this.TForm = tform;
            this.Right = right;
        }
        public string Translation { get; set; }
        public string FForm { get; set; }
        public string SForm { get; set; }
        public string TForm { get; set; }
        public bool Right { get; set; }

        public bool ChekFirstLetter(char c)
        {
            string s = FForm[0].ToString();
            if (s.ToUpper() == c.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}