using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWS_WSIZ.Models
{
    public class Validation
    {
        public static string valKabel(int iloscKabel)
        {
            if (iloscKabel < 0 || iloscKabel > 10)
            {
                return "Ilość kabli powinna zawierać się w przedziale od 0 do 10";
            }
            return null;
        }
        public static string valPrzylacz(int iloscPrzylacz)
        {
            if (iloscPrzylacz < 0 || iloscPrzylacz > 10)
            {
                return "Ilość przyłączy powinna zawierać się w przedziale od 0 do 10";
            }
            return null;
        }
        public static string valDlugoscPrzylacz(int dlugosc)
        {
            if (dlugosc < 0 || dlugosc > 50)
            {
                return "Długość przyłączy powinna zawierać się w przedziale od 0 do 50";
            }
            return null;
        }

        public static string valDlugoscPrzeslo(int dlugosc)
        {
            if (dlugosc < 0 || dlugosc > 100)
            {
                return "Długość przęsła powinna zawierać się w przedziale od 0 do 100";
            }
            return null;
        }
        public static string valNrSlupa(string nr)
        {
            if (nr.Length > 40)
            {
                return "Numer słupa nie może przekraczać 40 znaków";
            }
            if (nr.Length < 1)
            {
                return "Wprowadź numer słupa";
            }
            return null;
        }

        public static string valKatAlfa(int kat)
        {
            if (kat < 0 || kat > 170)
            {
                return "Kąt poninien zawierać się w przedziale od 0 do 170";
            }

            return null;
        }
    }
}
