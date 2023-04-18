using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Act7_CourseLevrier
{
    public partial class MainWindow : Window
    {
        Chien[] levriers = new Chien[4];
        int[] positionChien = new int[2];
        //timer
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            ImageChien();
            LancerCourse.Click += LancerCourse_Click;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(timer_Tick);
            BlocNumber.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            
        }
        public void ImageChien()
        {
            int[] positionChien = new int[2];
            positionChien[1] = 20;
            positionChien[0] = 60;
            for (int i = 0; i < 4; i++)
            {
                if(i > 0)
                {
                    positionChien[1] += 70;
                }
                levriers[i] = new Chien(600, i + 1, positionChien, false);
            }
        }

        private void LancerCourse_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++)
            {
                levriers[i].Courrir();
                if (levriers[i].PositionChien[0] >= 620)
                {
                    timer.Stop();
                }
            }
        }

        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            int x;
            if (int.TryParse(e.Text,out x))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
