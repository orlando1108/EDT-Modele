using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDT.BO
{
    class Eleve
    {
        private String _nom;

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private String _prenom;

        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        private String _mail;

        public String Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private Promotion _promotion;

        public Promotion Promotion
        {
            get { return _promotion; }
            set { _promotion = value; }
        }


        public Eleve(string nom, string prenom, string mail)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Mail = mail;
        }

        public int GetNbAbsences(DateTime dateDebut, DateTime dateFin)
        {
            return 0;
        }

    }
}
