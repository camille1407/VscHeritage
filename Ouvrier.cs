using System;

namespace VscHeritage
{
    class Ouvrier : Employe
    {
       private DateTime dateentree;
       private static double sMIG = 2500;

       public static double SMIG
       {
           get { return sMIG; }
           set { sMIG = value; }
       }
       public DateTime Dateentree
        {
            get { return dateentree; }
            set { dateentree = value; }
        }
        public Ouvrier(int mat, string n, string pre, DateTime dn, DateTime de)
            : base(mat, n, pre, dn)
        {
            this.dateentree = de;
        }
        public override string ToString()
        {
            return "Employé:"+" "+base.ToString()+"\n\nDate d'entrée: "+dateentree.ToShortDateString();
        }
        public override double GetSalaire()
        {
            double salaire;
            int Anciennete = DateTime.Now.Year - dateentree.Year;
            if (dateentree.AddYears(Anciennete) > DateTime.Now.Date)
                Anciennete--;
            if (sMIG + Anciennete * 100 <= 2 * sMIG)
                salaire = sMIG + Anciennete * 100;
            else
                salaire = sMIG * 2;
 
            return salaire;        
        }
    }
}
