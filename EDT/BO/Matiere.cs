using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDT.BO
{
    class Matiere
    {
        private String _nom;

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private List<Session> _listeSessions;

        public List<Session> ListeSessions
        {
            get { return _listeSessions; }
            set { _listeSessions = value; }
        }

        private List<Formateur> _listeFormateurs;

        public List<Formateur> ListeFormateurs
        {
            get { return _listeFormateurs; }
            set { _listeFormateurs = value; }
        }

        private List<Formation> _listeFormations;

        public List<Formation> ListeFormations
        {
            get { return _listeFormations; }
            set { _listeFormations = value; }
        }


        public Matiere(string nom)
        {
            this.Nom = nom;
        }

        

    }
}
