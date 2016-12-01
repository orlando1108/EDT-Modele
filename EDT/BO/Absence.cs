using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDT.BO
{
    class Absence
    {
        private Eleve _eleve;

        public Eleve Eleve
        {
            get { return _eleve; }
            set { _eleve = value; }
        }

        private Session _session;

        public Session Session
        {
            get { return _session; }
            set { _session = value; }
        }

        public Absence(Eleve eleve, Session session)
        {
            this.Eleve = eleve;
            this.Session = session;
        }


    }
}
