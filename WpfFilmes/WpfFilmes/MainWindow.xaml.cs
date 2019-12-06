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

namespace WpfFilmes
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = listaFilmes;

        }

        List<string> listaFilmes = new List<string>()
        {
            "Limite	",
            "Deus e o Diabo na Terra do Sol	",
            "Vidas Secas",
            "Cabra Marcado para Morrer",
            "Terra em Transe",
            "O Bandido da Luz Vermelha"

        };

        private void FiltrarLetras(string parametro)
        {
            dataGrid.ItemsSource = listaFilmes.Where(x => x.Contains(parametro));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FiltrarLetras(textBox.Text);
        }
    }
}
