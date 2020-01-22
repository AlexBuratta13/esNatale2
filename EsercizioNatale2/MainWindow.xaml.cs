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

namespace EsercizioNatale2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1 = int.Parse(txtN1.Text);
                int n2 = int.Parse(txtN2.Text);
                if(cmbScelta.SelectedIndex == 0)
                {
                    int somma = n1 + n2;
                    txtRisultato.Text = somma.ToString();
                }
                if(cmbScelta.SelectedIndex == 1)
                {
                    int sottrazione = n1 - n2;
                    txtRisultato.Text = sottrazione.ToString();
                }
                if (cmbScelta.SelectedIndex == 2)
                {
                    int moltiplicazione = n1 * n2;
                    txtRisultato.Text = moltiplicazione.ToString();
                }
                if (cmbScelta.SelectedIndex == 3)
                {
                    double divisione = ((double)n1 / n2);
                    txtRisultato.Text = divisione.ToString();
                }
            }
            catch(Exception Errore)
            {
                MessageBox.Show(Errore.Message,"Errore",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
