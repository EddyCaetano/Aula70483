﻿using SistemaDeNotas.Model;
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

namespace SistemaDeNotas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Aluno> Alunos = new List<Aluno>();

        private void BtnCadastra_Click(object sender, RoutedEventArgs e)
        {
            Alunos.Add(new Aluno()
            {
                Nome = tbxNome.Text,
                Nota1 = int.Parse(tbxNota1.Text),
                Nota2 = int.Parse(tbxNota2.Text),
                Nota3 = int.Parse(tbxNota3.Text)
            });
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Alunos;
            tbxNota1.Text = null;
            tbxNota2.Text = null;
            tbxNota3.Text = null;
            tbxNome.Text = null;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var pesquisa = Alunos.FirstOrDefault(x => x.Nome.Contains(tbxNome_Copy.Text));
            MessageBox.Show($"Nome do Aluno: {pesquisa.Nome} está {pesquisa.Status}");
        }
    }
}
