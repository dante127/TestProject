using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_
{

    class readon
    {
        private int id { get; set; }
        public string Name { get; set; }

        public readonly int sal ;

        public static int count = 0; 

        public readon()
        {
            id = count++;
            Name = "";
            sal = 0;
           
        }
        public readon(string n ,int s)
        {
            id = count++;
            Name = n;
            sal = s;
         
        }

        public readon(int s)
        {
            sal = s;
            id = count++;
        }

        public virtual string sum(string a, string b)
        {
            return "";
        }



        public override string ToString()
        {

            return " ID : " + id + "  " + "  Name : " + Name + "  sal :  " + sal + " Count : " + count;
        }
    }

    class t:readon
    {
        public override string sum(string a, string b)
        {
            return a + " " + b;
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            readon r1 = new readon(2000);
            r1.Name = "fouad";
            Console.WriteLine(r1);


            readon r2 = new readon("Seadra",3000);
            Console.WriteLine(r2);

            t t1 = new t();
           string s =  t1.sum(r1.Name, r2.Name);
            Console.WriteLine(s);
            readon r3 = new readon();
            Console.WriteLine(r3);
        }
    }
}
