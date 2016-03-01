using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        static public string StringToken(string str1, char sep, int nb)
        {
            string resultat = "";
            int compteur = 0;

            foreach(char c in str1)
            {
                if (c == sep)
                {
                    compteur++;
                }
                else
                {
                    if (compteur == nb)
                    {
                        resultat += c;
                    }
                }
            }

            return resultat;
        }
    }
}
