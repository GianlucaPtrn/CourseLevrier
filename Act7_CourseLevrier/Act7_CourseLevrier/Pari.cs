using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Act7_CourseLevrier
{
    class Pari
    {
		private int _montant;
		private int _numChien;
		private Parieur _joueur;

        public int Montant
        {
			get { return _montant; }
			set { _montant = value; }
		}

        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }

        public Parieur Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }

        //Constructeur 
        public Pari(int montant, int numChien, Parieur joueur)
        {
            Montant = montant;
            NumChien = numChien;
            Joueur = joueur;
        }

        // Méthode
        public void Win_or_Lose()
        {

        }

        public void PrixFinal()
        {

        }

    }
}
