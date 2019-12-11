using NotasAluno.Classes;
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

namespace NotasAluno
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Notas;
        }
        List<Media> Notas = new List<Media>
        {
            new Media()
            {
                Materia = "Geografia",
                Nota = 5                
            },
            new Media()
            {
                Materia = "Matemática",
                Nota = 8
            },
            new Media()
            {
                Materia = "Português",
                Nota = 3
            }

        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var media = Notas.Average(x => x.Nota);
            //string situacao = "APROVADO";
            //if (media < 7)
            //{
            //    situacao = "REPROVADO";
            //}
            MessageBox.Show($"Você está {(Notas.Average(x => x.Nota) < 7? "Reprovado!":"Aprovado!")}");//if de uma linha (ternário)
            //MessageBox.Show($"Sua média é: {media} {situacao}");
        }
    }
}
