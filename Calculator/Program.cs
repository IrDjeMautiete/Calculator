using System;
using System.Diagnostics;
using System.Collections;
using System.Globalization;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using System.Text;
using System.Net;
using System.Net.Http;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // FOUS TON CODE ICI !!!

            Tools.AskInteger("Outah",0,9);



            Console.WriteLine("\nDurée d’exécution: " + stopwatch.Elapsed.TotalSeconds);
        }
    }
}
