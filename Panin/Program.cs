using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panin
{
    class Program
    {
        public static void Main(string[] args)
        {
            Soal01();

            Console.ReadKey();
        }

        public static void Soal01()
        {
            string sInput = Console.ReadLine();
            int iInput = Convert.ToInt32(sInput);

            for (int i = 0; i < sInput.Length-1; i++)
            {
                if (i==0)
                {
                    string sPengurang = sInput.Substring(i + 1);
                    int iPengurang = Convert.ToInt32(sPengurang);

                    int iHasil = iInput - iPengurang;
                    string sHasil = Convert.ToString(iHasil);
                    Console.WriteLine(sHasil);
                }
                else
                {
                    string sPengurang = sInput.Substring(i + 1);
                    int iPengurang = Convert.ToInt32(sPengurang);

                    int iHasil = iInput - iPengurang;

                    int iAwalHasil = Convert.ToInt32(sInput.Substring(i));
                    int iTengahHasil = iInput - iAwalHasil;
                    int iAkhirHasil = iHasil - iTengahHasil;

                    string sAkhirHasil = Convert.ToString(iAkhirHasil);

                    Console.WriteLine(sAkhirHasil);
                }
            }
            Console.WriteLine(sInput.Substring(sInput.Length - 1));
        }
    }
}
