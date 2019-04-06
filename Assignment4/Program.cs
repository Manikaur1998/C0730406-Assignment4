using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace Assignment4
{
    class Program
    {
        //Manpreet kaur(730406)

        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();

            Console.ReadLine();
        }
        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:\\Users\\730406\\manni bithday\\Beowulf.txt"))
            {

                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();

                counter = File.ReadLines("U:\\Users\\730406\\manni bithday\\Beowulf.txt").Count();

                Console.WriteLine("\n Number of lines : " + counter);



            }
        }
       
    }
}