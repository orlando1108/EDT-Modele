using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDT.BO
{
    class Formation
    {
        private String _nom;

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private float _nbHeuresTotal;

        public float NbHeuresTotal
        {
            get { return _nbHeuresTotal; }
            set { _nbHeuresTotal = value; }
        }

        private List<Matiere> _listeMatieres;

        public List<Matiere> ListeMatieres
        {
            get { return _listeMatieres; }
            set { _listeMatieres = value; }
        }

        private List<Promotion> _listePromotions;

        public List<Promotion> ListePromotions
        {
            get { return _listePromotions; }
            set { _listePromotions = value; }
        }


        public Formation(string nom, float nbHeuresTotal)
        {
            this.Nom = nom;
            this.NbHeuresTotal = nbHeuresTotal;
        }
    }
}
