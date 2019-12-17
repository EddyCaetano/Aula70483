using SistemaContrtoleEstoque.Controller;
using SistemaContrtoleEstoque.Model;
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
using System.Windows.Shapes;

namespace SistemaContrtoleEstoque.View
{
    /// <summary>
    /// Lógica interna para CadastraNovoUsuario.xaml
    /// </summary>
    public partial class CadastraNovoUsuario : Window
    {
        public CadastraNovoUsuario()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbxSenha.Password != tbxConfirmar.Password)
            {
                MessageBox.Show("As senhas não conferem!");
                return;
            }
            new UsuarioController().CadastraNovoUsuario(new Usuario()
            {
                Login = tbxLogin.Text,
                Senha = tbxSenha.Password

            });
            DialogResult = true;// para fechar o dialogo
        }
    }
}
