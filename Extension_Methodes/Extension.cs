using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Methodes
{
    public static class Extension
    {
        public static int AnzahlBuchstaben(this string s) {
            return s.Length;
        }

        // Split erwartet ein Array of char mit mindestens einem Trennzeichen
        // vom Typ char, hier Leerzeichen, Punkt, und Fragezeichen
        // - optional kann new char[] entfallen!
        public static int AnzahlWörter(this String str) {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // Unser Kopierschutz ;-)
        public static string AddCopyright(this string text, string company, int distance) {
            StringBuilder sb = new StringBuilder();
            string[] stringArray = text.Split(new char[] { ' ' });

            for (int i= 0; i < stringArray.Length; i++) {

               if (i % distance == 0) {
                    sb.Append(" "+company);
                }
                sb.Append(" " +stringArray[i] );                
            }
            return sb.ToString();
        }
    }
}
