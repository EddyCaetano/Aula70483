using ListaCarrosObj.Classes;
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

namespace ListaCarrosObj
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Carros;
        }
        List<Carro> Carros = new List<Carro>
        {
             new Carro
             {
                  Marca = "Brasil Carros",
                  Modelo = "Bug",
                  Ano = 1980
             },

             new Carro
             {
                 Marca = "Ford",
                 Modelo = "Mustang",
                 Ano = 1979
             },

             new Carro
             {
                 Marca = "Chevrolet",
                 Modelo = "Camaro",
                 Ano = 1969
             }

        };
    }
}
