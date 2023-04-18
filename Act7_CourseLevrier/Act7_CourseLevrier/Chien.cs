using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Act7_CourseLevrier
{
    class Chien
    {
        //Instanciation
        int _longeurPiste;
        int _numChien;
        Image _imgChien;
        int[] _positionChien;
        bool _gagne;

        //Propriété
        public int LongeurPiste
        {
            get { return _longeurPiste; }
            set { _longeurPiste = value; }
        }
        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }

        public Image ImgChien
        {
            get { return _imgChien; }
            set { _imgChien = value; }
        }
        public int[] PositionChien
        {
            get { return _positionChien; }
            set { _positionChien = value; }
        }
        public bool Gagne
        {
            get { return _gagne; }
            set { _gagne = value; }
        }

        //Constructeur 
        public Chien(int longeurPiste, int numChien, int[] positionChien, bool gagne)
        {
            _longeurPiste = longeurPiste;
            _numChien = numChien;

            MainWindow plateau = (Act7_CourseLevrier.MainWindow)App.Current.MainWindow;
            BitmapImage imageChien = new BitmapImage();
            imageChien.BeginInit();
            imageChien.UriSource = new Uri("/Images/dog.png", UriKind.Relative);
            imageChien.EndInit();
            _imgChien = new Image();
            _imgChien.Source = imageChien;
            _imgChien.Stretch = System.Windows.Media.Stretch.None;
            Canvas.SetLeft(_imgChien, positionChien[0]);
            Canvas.SetTop(_imgChien, positionChien[1]);
            plateau.piste.Children.Add(_imgChien);

            _positionChien = new int[2];
            PositionChien[0] = positionChien[0];
            PositionChien[1] = positionChien[1];
            _gagne = gagne;
        }

        // Méthode
        public void Courrir()
        {
            Random random = new Random();
            int nombreAleatoire = random.Next(30, 71);
            _positionChien[0] += nombreAleatoire;
            Canvas.SetLeft(_imgChien, _positionChien[0]);
        }
    }
}
