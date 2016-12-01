using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDT.BO
{
    class Salle:Destinataire
    {
        private String _nom;

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private int _capacite;

        public int Capacite
        {
            get { return _capacite; }
            set { _capacite = value; }
        }

        private List<Session> _listeSessions;

        public List<Session> ListeSessions
        {
            get { return _listeSessions; }
            set { _listeSessions = value; }
        }


        public Boolean EstDisponible(DateTime dateDebut, DateTime dateFin)
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
        }
    }
}
