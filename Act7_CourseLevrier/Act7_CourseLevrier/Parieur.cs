using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Act7_CourseLevrier
{
    class Parieur
    {
		private int _nom;
		private Pari _monPari;
		private int _cash;
		private TextBlock _textBlocEtatPari;

        public int Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public Pari MonPari
        {
            get { return _monPari; }
            set { _monPari = value; }
        }
        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }
        public TextBlock TextBlocEtatPari
        {
            get { return _textBlocEtatPari; }
            set { _textBlocEtatPari = value; }
        }

        //Constructeur 
        public Parieur(int nom, Pari monPari, int cash, TextBlock textBlocEtatPari)
        {
            Nom = nom;
            MonPari = monPari;
            Cash = cash;
            TextBlocEtatPari = textBlocEtatPari;
        }

        // Méthode
        public void Parie(int montant, int numChien, Parieur joueur)
        {
            Pari monPari = new Pari(montant, numChien, joueur);
        }

        public void PerdreArgent(int argentRetiree)
        {
            Cash -= argentRetiree;
            MessageBox.Show(" Dommage vous avez perdu, vous allez vous rattrappé");
        }

        public void GagnerArgent(int argentAjoutee)
        {
            Cash += argentAjoutee * 2;
            MessageBox.Show("Félicitation vous avez gagner votre pari");
        }
    }
}
