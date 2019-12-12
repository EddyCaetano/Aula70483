using PossoaBancoDeDados.Models;
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

namespace PossoaBancoDeDados
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Pessoas.ToList<Pessoa>();
        }
        PessoaContext Context = new PessoaContext();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Context.Pessoas.Add(new Pessoa()
            {
                Nome = "Rubervaldo",
                Idade = 47,
                Data = DateTime.Now
            });
            Context.SaveChanges();
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Pessoas.ToList<Pessoa>();
        }
    }
}
