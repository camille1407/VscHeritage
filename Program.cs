using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VscHeritage
{
    class Program
    {  
        static void Main(string[] args)
        {
            Ouvrier o = new Ouvrier(1, "Abalo", "john", new DateTime(1980, 2, 3), new DateTime(1995, 4, 5));
            Console.Out.WriteLine(o);
            Console.Out.WriteLine("Salaire de l'Employé: " + o.GetSalaire());
            Console.Out.WriteLine("***********************************");
            Cadre c = new Cadre(2, "Jojo", "Alice", new DateTime(1986, 4, 3), 2);
            Console.Out.WriteLine(c);
            Console.Out.WriteLine("Le salaire du cadre est: " + c.GetSalaire());
            Console.Out.WriteLine("***********************************");
            Patron.Ca = 17000000;
            Patron p = new Patron(3, "Camille", "Anani", new DateTime(1970, 6, 6), 4);
            Console.Out.WriteLine(p);
            Console.Out.WriteLine("Le salaire du patron est: " + p.GetSalaire());
            
        }
       
    }
}
