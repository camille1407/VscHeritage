using System;

namespace VscHeritage
{
    class Patron : Employe
    {
        private static double ca;
        private double pourcentage;

        public static double Ca
        {
            get { return ca; }
            set { ca = value; }
        }
        public double Pourcentage 
        {
            get { return pourcentage; }
            set { pourcentage = value;}            
        }
        public Patron(int mat, string n, string pre, DateTime dn, double p)
               :base(mat, n, pre, dn)
        {
            this.pourcentage = p;
        }       
        public override string ToString()
        {
            
            return "Patron: "+" "+base.ToString()+"\n\nPourcentage: "+pourcentage+"%";
        }
        public override double GetSalaire()
        {                   
            return Math.Round((ca * pourcentage / 100) / 12, 2);            
        }
    }
}    