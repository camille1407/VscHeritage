using System;

namespace VscHeritage
{
    public abstract class Employe
    {
        private int matricule;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public int Matircule
        {
            get { return Matircule; }
            set { Matircule = value; }
        }
 
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
 
        public string Prenom
        {
            get { return Prenom; }
            set { prenom = value; }
        }
 
        public DateTime Datenaissance
        {
            get { return Datenaissance; }
            set { Datenaissance = value; }
        }
        public Employe(int mat,string n,string pre,DateTime dn)
        {
            this.matricule = mat;
            this.nom = n;
            this.prenom = pre;
            this.dateNaissance = dn;
        }
        public override string ToString()
        {
           return "\n\nMatricule: "+ matricule + "\n\nNom: " + nom + "\n\nPrénom: " + 
           prenom + "\n\nDate de naissance: "+ 
           dateNaissance.ToShortDateString();
        }
        public abstract double GetSalaire();
    }
}
