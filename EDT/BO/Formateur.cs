using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDT.BO
{
    class Formateur :Destinataire
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
        private String _telephone;

        public String Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        private List<Session> _listeSessions;

        public List<Session> ListeSessions
        {
            get { return _listeSessions; }
            set { _listeSessions = value; }
        }

        private List<Matiere> _listeMatieres;

        public List<Matiere> ListeMatieres
        {
            get { return _listeMatieres; }
            set { _listeMatieres = value; }
        }


        public Formateur( string nom, string prenom, string mail, string tel)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Mail = mail;
            this.Telephone = tel;
        }

        public float NbHeuresTravaillees(DateTime debutPeriode, DateTime finPeriode)
        {
            return 0;
        }

        public Boolean EstDisponible()
        {
            return false;
        }

        public List<Session> GetSessions(DateTime dateDebut, DateTime dateFin)
        {
            List<Session> listeSessions_toReturn = new List<Session>();
            if (ListeSessions != null)
            {
                foreach (Session session in ListeSessions)
                {
                    if (session.DateDebut < dateDebut && session.DateFin > dateDebut ||
                       session.DateDebut > dateDebut && session.DateFin < dateFin ||
                       session.DateDebut < dateFin && session.DateFin > dateFin)
                    {
                        listeSessions_toReturn.Add(session);
                    }
                }
            }

            return listeSessions_toReturn;
           // throw new NotImplementedException();
        }

    }
}
