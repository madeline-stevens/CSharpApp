using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formattedDate = "";
            //first Format : 26-09-18 08:35:00
            formattedDate = string.Format("{0:dd-MM-yyyy HH:mm:ss", myDate);
            Console.WriteLine(formattedDate);

            //second format : Saturday of month September 2018
            formattedDate = string.Format("{0:dddd ' of month' MMMM 'year' yyyy}", myDate);
            Console.WriteLine(formattedDate);


            /*third format 
            * Day Wednesday
            * Month September 
            * Year 2017
            */

            formattedDate = string.Format("{0: 'Day' dddd \n 'Month' MMMM \n 'Year' yyyy}", myDate);
            Console.WriteLine(formattedDate);

        }
    }
}