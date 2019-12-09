using IniciandoClasse.Classes;
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

namespace IniciandoClasse
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Criancas;
        }
        List<Crianca> Criancas = new List<Crianca>
        {
             new Crianca()
             {
                   Nome = "Eddy",
                   Idade = 7
             },
             new Crianca()
             {
                 Nome = "Robervaldo",
                 Idade = 12
             },
             new Crianca()
             {
                 Nome = "Juvenir",
                 Idade = 15
             }
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Criancas.ForEach(x => MessageBox.Show($@"Nome: {x.Nome} \ Idade: {x.Idade}"));
        }
    }
}
