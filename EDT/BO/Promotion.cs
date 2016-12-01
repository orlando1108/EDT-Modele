using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDT.BO
{
    class Promotion:Destinataire
    {
        private String _nom;

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private DateTime _dateDebut;

        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }
        private DateTime _dateFin;

        public DateTime DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }

        private Formation _formation;

        public Formation Formation
        {
            get { return _formation; }
            set { _formation = value; }
        }

        private List<Session> _listeSessions;

        public List<Session> ListeSessions
        {
            get { return _listeSessions; }
            set { _listeSessions = value; }
        }

        private List<Eleve> _listeEleves;

        public List<Eleve> ListeEleves
        {
            get { return _listeEleves; }
            set { _listeEleves = value; }
        }


        public Promotion( string nom, DateTime dateDebut, DateTime dateFin)
        {
            this.Nom = nom;
            this.DateDebut = dateDebut;
            this.DateFin = DateFin;
        }

        public Boolean EstDisponible(DateTime dateDebut, DateTime dateFin)
        {
            foreach(Session session in _listeSessions)
            {
                if(session.DateDebut< dateDebut && session.DateFin > dateDebut ||
                    session.DateDebut > dateDebut && session.DateFin < dateFin || 
                    session.DateDebut < dateFin && session.DateFin > dateFin)
                {
                    return false;
                }
            }
            return true;
        }

        public List<Session> GetSessions(DateTime dateDebut, DateTime dateFin)
        {
            List<Session> listeSessions_toReturn = new List<Session>();
            if(ListeSessions != null)
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
        }
    }
}
