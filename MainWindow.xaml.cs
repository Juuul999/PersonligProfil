using System;
using System.Collections.Generic;
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

namespace PersonligProfil
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool isTextChanged = false; // Tilstand til at holde styr på, om teksten er blevet ændret

        private void ChangeTextButton_Click(object sender, RoutedEventArgs e)
        {
            if (isTextChanged)
            {
                // Skift tilbage til oprindelig tekst
                HvorforProjekt.Text = "Hvorfor har jeg lavet dette projekt?";
            }
            else
            {
                // Skift til den nye tekst
                HvorforProjekt.Text = "Jeg har valgt at lave dette projekt for at vise lidt kodning jeg har lært. Prøv at trykke på knappen igen!";
            }

            // Toggle tilstanden
            isTextChanged = !isTextChanged;
        }


        private void TestBoxTest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TestBoxTest_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Jeg er ung, og ny til programmering og leder efter et sted hvor jeg kan udvikle mig som person og programmør. Jeg har begrænset erfaring indenfor kodning specifikt, og kan derfor formes efter hvad i har brug for.");
        }

        private void HvorforProjekt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ProfilTekst_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
