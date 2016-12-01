using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDT.BO
{
    class EmploiDuTemps
    {
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

        private List<Session> _listeSessions;

        public List<Session> ListeSessions
        {
            get { return _listeSessions; }
            set { _listeSessions = value; }
        }

    }
}
