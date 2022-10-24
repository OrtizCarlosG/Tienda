using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Tienda.Class
{
    class EAN13
    {
        public static string BarCode13Digits = "";

        public static string EAN13String(string chaine)
        {
            int i, first, checksum = 0;
            string barcode = "";
            bool tableA;
            if (Regex.IsMatch(chaine, "^\\d{12}$"))
            {
                for (i = 1; i < 12; i += 2)
                {
                    checksum += Convert.ToInt32(chaine.Substring(i, 1));
                }

                checksum *= 3;
                for (i = 0; i < 12; i += 2)
                {
                    checksum += Convert.ToInt32(chaine.Substring(i, 1));
                }

                chaine += (10 - checksum % 10) % 10;
                barcode = chaine.Substring(0, 1) + (65 + Convert.ToInt32(chaine.Substring(1, 1)));
                first = Convert.ToInt32(chaine.Substring(0, 1));

                for (i = 2; i <= 6; i++)
                {
                    tableA = false;
                    switch(i)
                    {
                        case 2:
                            if (first >= 0 && first <= 3) tableA = true;
                            break;
                        case 3:
                            if (first == 0 || first == 4 || first == 7 || first == 8) tableA = true;
                            break;
                        case 4:
                            if (first == 0 || first == 1 || first == 4 || first == 5 || first == 9) tableA = true;
                            break;
                        case 5:
                            if (first == 0 || first == 2 || first == 5 || first == 6 || first == 7) tableA = true;
                            break;
                        case 6:
                            if (first == 0 || first == 3 || first == 6 || first == 8 || first == 9) tableA = true;
                            break;

                    }
                    if (tableA)
                    {
                        barcode += (char) (65 + Convert.ToInt32(chaine.Substring(i, 1)));
                    } else
                    {
                        barcode += (char)(75 + Convert.ToInt32(chaine.Substring(i, 1)));
                    }

                }

                barcode += "*";

                for (i = 7; i < 12; i++)
                {
                    barcode += (char) (97 + Convert.ToInt32(chaine.Substring(i, 1)));
                }

                barcode += "+";

            }
            return barcode;
        }
    }
}
