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

namespace IniciandoWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = listaNomes;
        }
        List<string> listaNomes = new List<string>()
        {
            "Chael",
            "Rocneth",
            "Liamcyn",
            "Dicjohn",
            "Dahe",
            "Chellren",
            "Kimni",
            "Hadod",
            "Garnyahildi",
            "Reginisen",
            "Danmax",
            "Leysig",
            "Hesfastnath",
            "Jenba",
            "Marmaand",
            "Gorma",
            "Helm",
            "Isumlin",
            "Jenann",
            "Doegar"
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;

                switch (cbxFiltro.SelectedIndex)
            {
                case 0:
                    OrdernarLista();
                    break;

                case 1:
                    FiltraPorLetras(tbxFiltro.Text);
                    break;
                case 2:
                    OrdenarMaiorParaMenor();
                    break;
                
            }
        }
        private void OrdernarLista()
        {
            //Ordenar alfabeticamente
            dataGrid.ItemsSource = listaNomes.OrderBy(x => x);
        }

        private void OrdenarMaiorParaMenor()
        {
            dataGrid.ItemsSource = listaNomes.OrderByDescending(x => x.Length);
        }

        private void FiltraPorLetras(string parametro)
        {
            
            dataGrid.ItemsSource = listaNomes.Where(x => x.Contains(parametro));

        }
    }
}
