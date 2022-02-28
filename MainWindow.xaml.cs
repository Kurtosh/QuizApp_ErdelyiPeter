using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizApp_ErdélyiPéter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] kerdesek;
        public string[] valaszok;
        public string[] hValaszok;
        public MainWindow()
        {
            InitializeComponent();
            kerdesek = File.ReadAllLines("Kérdések.txt");
            kerdes.Content = kerdesek[0];
            valaszok = File.ReadAllLines("Válaszok.txt");
            gomb1.Content = valaszok[0];
            gomb2.Content = valaszok[1];
            gomb3.Content = valaszok[2];
            gomb4.Content = valaszok[3];
            hValaszok = File.ReadAllLines("Helyes.txt");
            
        }
        private void kovetkezo_Click(object sender, RoutedEventArgs e)
        {
            PB.Value++;
            if (PB.Value > 1)
            {
                elozo.IsEnabled = true;

            }
            else
            {
                elozo.IsEnabled = false;
            }
            for (int i = 1; i <= 10; i++)
            {
                if (PB.Value == i)
                {
                    kerdes.Content = kerdesek[i - 1];
                    gomb1.Content = valaszok[(i - 1) * 4];
                }
            }
            if (PB.Value == 1)
            {
                gomb2.Content = valaszok[1];
                gomb3.Content = valaszok[2];
                gomb4.Content = valaszok[3];
            }
            if (PB.Value == 2)
            {
                gomb2.Content = valaszok[5];
                gomb3.Content = valaszok[6];
                gomb4.Content = valaszok[7];
            }
            if (PB.Value == 3)
            {
                gomb2.Content = valaszok[9];
                gomb3.Content = valaszok[10];
                gomb4.Content = valaszok[11];
            }
            if (PB.Value == 4)
            {
                gomb2.Content = valaszok[13];
                gomb3.Content = valaszok[14];
                gomb4.Content = valaszok[15];
            }
            if (PB.Value == 5)
            {
                gomb2.Content = valaszok[17];
                gomb3.Content = valaszok[18];
                gomb4.Content = valaszok[19];
            }
            if (PB.Value == 6)
            {
                gomb2.Content = valaszok[21];
                gomb3.Content = valaszok[22];
                gomb4.Content = valaszok[23];
            }
            if (PB.Value == 7)
            {
                gomb2.Content = valaszok[25];
                gomb3.Content = valaszok[26];
                gomb4.Content = valaszok[27];
            }
            if (PB.Value == 8)
            {
                gomb2.Content = valaszok[29];
                gomb3.Content = valaszok[30];
                gomb4.Content = valaszok[31];
            }
            if (PB.Value == 9)
            {
                gomb2.Content = valaszok[33];
                gomb3.Content = valaszok[34];
                gomb4.Content = valaszok[35];
            }
            if (PB.Value == 10)
            {
                gomb2.Content = valaszok[37];
                gomb3.Content = valaszok[38];
                gomb4.Content = valaszok[39];
            }
        }

        private void elozo_Click(object sender, RoutedEventArgs e)
        {
            PB.Value--;
            if (PB.Value > 1)
            {
                elozo.IsEnabled = true;

            }
            else
            {
                elozo.IsEnabled = false;
            }
            for (int i = 1; i <= 10; i++)
            {
                if (PB.Value == i)
                {
                    kerdes.Content = kerdesek[i - 1];
                    gomb1.Content = valaszok[(i - 1) * 4];
                }
            }
            if (PB.Value == 1)
            {
                gomb2.Content = valaszok[1];
                gomb3.Content = valaszok[2];
                gomb4.Content = valaszok[3];
            }
            if (PB.Value == 2)
            {
                gomb2.Content = valaszok[5];
                gomb3.Content = valaszok[6];
                gomb4.Content = valaszok[7];
            }
            if (PB.Value == 3)
            {
                gomb2.Content = valaszok[9];
                gomb3.Content = valaszok[10];
                gomb4.Content = valaszok[11];
            }
            if (PB.Value == 4)
            {
                gomb2.Content = valaszok[13];
                gomb3.Content = valaszok[14];
                gomb4.Content = valaszok[15];
            }
            if (PB.Value == 5)
            {
                gomb2.Content = valaszok[17];
                gomb3.Content = valaszok[18];
                gomb4.Content = valaszok[19];
            }
            if (PB.Value == 6)
            {
                gomb2.Content = valaszok[21];
                gomb3.Content = valaszok[22];
                gomb4.Content = valaszok[23];
            }
            if (PB.Value == 7)
            {
                gomb2.Content = valaszok[25];
                gomb3.Content = valaszok[26];
                gomb4.Content = valaszok[27];
            }
            if (PB.Value == 8)
            {
                gomb2.Content = valaszok[29];
                gomb3.Content = valaszok[30];
                gomb4.Content = valaszok[31];
            }
            if (PB.Value == 9)
            {
                gomb2.Content = valaszok[33];
                gomb3.Content = valaszok[34];
                gomb4.Content = valaszok[35];
            }
            if (PB.Value == 10)
            {
                gomb2.Content = valaszok[37];
                gomb3.Content = valaszok[38];
                gomb4.Content = valaszok[39];
            }
        }
    }
}
