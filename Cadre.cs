using System;

namespace VscHeritage
{
    class Cadre : Employe
    {
        private int indice;
        public int Indice
        {
            get { return indice; }
            set { indice = value; }          
        }
        public Cadre(int mat, string n, string pre, DateTime dn, int indice)
            : base(mat, n, pre, dn)
        {
            this.indice = indice;
        }
        public override string ToString()
        {
            return "Cadre: "+" "+base.ToString()+"\n\nIndice: "+indice;
        }
        public override double GetSalaire()
        {
            if (indice == 1)
                return 13000;
            else if (indice == 2)
                return 15000;
            else if (indice == 3)
                return 17000;
            else if (indice == 4)
                return 20000;
            else
                return -1; 
        }

    }
}    