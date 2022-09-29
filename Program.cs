using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FringillaFunctionality1
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //public static string[] ExtractUsefullData(string fileNames)
        //{
        //    string[] output = { "avgDistBckg" , "avgDistFilm" , "0shift" , "n" , "lambda" , "thickness" };

        //    output[0] = Convert.ToString(248);  //average distance background
        //    output[1] = Convert.ToString(248.5f);  //average distance film
        //    output[2] = Convert.ToString(66);  //0 order shift
        //    output[3] = Convert.ToString(0);  //n number to check formula
        //    output[4] = Convert.ToString(552);  //lambda
        //    output[5] = Convert.ToString(73.4f);  //thickness

        //    return output;
        //}
    }
}
