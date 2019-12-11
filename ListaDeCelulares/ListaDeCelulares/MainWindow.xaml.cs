using ListaDeCelulares.Classes;
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

namespace ListaDeCelulares
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Celulars;
        }
        List<Celular> Celulars = new List<Celular>
        {
            new Celular()
            {
                Modelo = "MI8 Lite 6",
                Marca = "XIAOMI",
                Bateria = 3350,
                MemoriaRAM = 6,
                MemoriaROM = 128,
                Valor = (decimal)1400.00 //CAST converte o tipo da VAR se tem a mesma propriedade, no caso aqui é número.
            },
            
            new Celular()
            {
                Modelo = "K9",
                Marca = "LG",
                Bateria = 2500,
                MemoriaRAM = 4,
                MemoriaROM = 16,
                Valor = (decimal)369.00
            },

            new Celular()
            {
                Modelo = "IPhone 11",
                Marca = "Aple",
                Bateria = 3110,
                MemoriaRAM = 6,
                MemoriaROM = 256,
                Valor = (decimal)9599.59
            }
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Valor Total {Celulars.Sum(x=> x.Valor).ToString("C")}");//linq
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Baterial Toral {Celulars.Sum(x => x.Bateria).ToString("N")}");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Valor Total {Celulars.Average(x => x.Valor).ToString("C")}");
        }
    }
}
