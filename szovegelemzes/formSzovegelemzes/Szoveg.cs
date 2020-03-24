using System;
namespace szovegelemzes
{
    public class Szoveg
    {
        public static char[] nembetukarakterek = { ' ', '.', '!', '%', '(', ')', '?', ',', '-', '+', '/', '@',':',';','0','1','2','3','4','5','6','7','8','9' };
        public static char[] maganhangzok = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
        public static char[] massalhangzok = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

        public static int HanyBetu(string be, char[] mindenmas)
        {
            int count = 0;
            for (int i = 0; i < be.Length; i++)
            {
                for (int j = 0; j < mindenmas.Length; j++)
                {
                    if (Convert.ToChar(be[i]) == mindenmas[j])
                    {
                        count++;
                    }
                }
                
            }
            return be.Length - count;
        }
        public static int HanyMaganhangzo(string be, char[] maganhangzok)
        {
            int countMaganhangzok = 0;

            for (int i = 0; i < be.Length; i++)
            {
                for (int j = 0; j < maganhangzok.Length; j++)
                {
                    if (Convert.ToChar(be[i]) == maganhangzok[j])
                    {
                        countMaganhangzok++;
                    }
                }
            }
            return countMaganhangzok;
        }
        public static int HanyMassalhangzo(string be, char[] massalhangzok)
        {
            int countMassalhangzok = 0;
            for (int i = 0; i < be.Length; i++)
            {
                for (int j = 0; j < massalhangzok.Length; j++)
                {
                    if (Convert.ToChar(be[i]) == massalhangzok[j])
                    {
                        countMassalhangzok++;
                    }
                }
            }
            return countMassalhangzok;
        }
    }
}
