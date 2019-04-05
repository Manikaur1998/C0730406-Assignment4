using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        //Manpreet kaur(730406)
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();

            public void Run()

this.Read TextFiles();
        }

        public void Read TextFiles()

// Read file using StreamReader. Read file line by line
using (StreamReader file = new StreamReader("C:/area51/beowulf.txt"))
    {
    int counter 0;
string In

while ((in = file.ReadLine()) != null)

Console.WriteLine(1n );
Beowulf.Add(1n)

file.close();
Console.WriteLine($"File has {contour} lines.");
        }
}


public int Find Number Of Blank Spaces(string line)

// https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-s

int countletters = 0;
int countSpaces = 0;

foreach (char c in line)

if (char.IsLetter(c)) { count letters c++;}
if (char.IsWhiteSpace()) { countSpaces++; }

return countSpaces;

}

    }

}
    }


