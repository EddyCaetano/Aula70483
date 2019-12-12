using CadastroTelefone.Models;
using CadastroTelefone.View;
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

namespace CadastroTelefone
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
            dataGrid.ItemsSource = Context.Telefones.ToList<Telefone>();
        }
        TelefoneContext Context = new TelefoneContext();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadTelefone cadTelefone = new CadTelefone();
            cadTelefone.ShowDialog();

            Context.Telefones.Add(cadTelefone.Telefone);
            Context.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Telefones.ToList<Telefone>();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)//quando em execução clicar botão direito quickwath no sewnder
        {
            var index = ((System.Windows.Controls.Primitives.Selector)sender).SelectedIndex;

            Context.Telefones.Remove((Telefone)dataGrid.Items[index]);
            Context.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Telefones.ToList<Telefone>();
        }
    }
}
