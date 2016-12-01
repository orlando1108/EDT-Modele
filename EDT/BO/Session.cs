using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDT.BO
{
    class Session
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

        private List<EmploiDuTemps> _listeEdt;

        public List<EmploiDuTemps> ListeEdt
        {
            get { return _listeEdt; }
            set { _listeEdt = value; }
        }

        private Promotion _promotion;

        public Promotion Promotion
        {
            get { return _promotion; }
            set { _promotion = value; }
        }

        private Matiere _matiere;

        public Matiere Matiere
        {
            get { return _matiere; }
            set { _matiere = value; }
        }
        private Formateur _formateur;

        public Formateur Formateur
        {
            get { return _formateur; }
            set { _formateur = value; }
        }

        private Salle _salle;

        public Salle Salle
        {
            get { return _salle; }
            set { _salle = value; }
        }


        public Session(DateTime dateDebut, DateTime dateFin, Promotion promotion, Matiere matiere, Salle salle, Formateur formateur = null)
        {
            this.DateDebut = dateDebut;
            this.DateFin = DateFin;
            this.Promotion = promotion;
            this.Matiere = matiere;
            this.Salle = salle;
            this.Formateur = formateur;
        }

    }
}
