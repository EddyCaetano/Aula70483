using CadastrarPesssoaObj.Classes;
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

namespace CadastrarPesssoaObj
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Pessoas;
        }
        List<Pessoa> Pessoas = new List<Pessoa>
        {
            new Pessoa
            {
                Nome = "Edvaldo Correa",
                Data = DateTime.Parse("11/05/1995")
            }
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pessoas.Add(new Pessoa()
            {
               Nome = tbxNome.Text,
               Data = Convert.ToDateTime(DateTime.Parse(tbxData.Text))
            });

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Pessoas;
        }
    }
}
