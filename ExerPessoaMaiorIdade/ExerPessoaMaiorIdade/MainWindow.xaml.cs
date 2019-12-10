using ExerPessoaMaiorIdade.Classes;
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

namespace ExerPessoaMaiorIdade
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
            new Pessoa()
            {
                NomeCompleto = "Robervaldino Justo",
                Data = DateTime.Parse("25/03/1987")
            },
            new Pessoa()
            {
                NomeCompleto = "Evaristo Costa",
                Data = DateTime.Parse("05/12/2008")
            },
            new Pessoa()
            {
                NomeCompleto = "Marvelino Paes",
                Data = DateTime.Parse("31/12/2001")
            }
        };
    }
}
