﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShard_3cs2_Lad_P2_Salary
{
    class KeyBord
    {
       public static InputLanguage eng, lao;
        public static void  getKeyBord()
        {
            foreach(InputLanguage l in InputLanguage.InstalledInputLanguages)
            {
                if (l.LayoutName.Contains("ENG"))
                {
                    eng = l;
                }
                else if(l.LayoutName.Contains("Lao"))
                {
                    lao = l;
                }
            }
        }
    }
}
