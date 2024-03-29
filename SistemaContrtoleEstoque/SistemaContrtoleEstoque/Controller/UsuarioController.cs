﻿using SistemaContrtoleEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContrtoleEstoque.Controller
{
    class UsuarioController
    {
        SistemaContext ctx;
        public UsuarioController()
        {
            ctx = new SistemaContext(); 

        }
        public bool VerificaUsuarioExiste(string usuario, string senha)
        {
            return ctx.Usuarios.ToList<Usuario>().Exists(x => x.Login == usuario && x.Senha == Hash(senha));

        }
        public void CadastraNovoUsuario(Usuario item)
        {
            item.Senha = Hash(item.Senha);
            ctx.Usuarios.Add(item);
            ctx.SaveChanges();
        }
        public List<Usuario> GetUsuarios()
        {
            return ctx.Usuarios.ToList();
        }

        string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }
    }
}
