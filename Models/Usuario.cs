using System;
using System.Collections.Generic;
using System.IO;

namespace Instadev_06.Models
{
    public class Usuario : InstadevBase , IUsuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public DateTime DataNascimento { get; set; }
        public int[] Seguidos { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }

        public const string PATH = "Database/Usuarios.csv";

        public string _PATH {
            get{return PATH;}
        }

        public Usuario() {
            CreateFolderAndFile(PATH);
        }

        //Prepara a linha do CSV
        public string PrepareLine(Usuario u)
        {
            return $"{u.IdUsuario};{u.Nome};{u.Foto};{u.DataNascimento};{u.Username};{u.Email};{u.Senha}";
        }

        public void Create(Usuario u)
        {
            string[] linhas = {PrepareLine(u)};

            File.AppendAllLines(PATH, linhas);
        }

        public List<Usuario> ReadAll()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] linha = item.Split(";");

                Usuario novoUsuario = new Usuario();
                novoUsuario.IdUsuario = int.Parse(linha[0]);
                novoUsuario.Nome = linha[1];
                novoUsuario.Foto = linha[2];
                novoUsuario.DataNascimento = DateTime.Parse(linha[3]);
                novoUsuario.Username = linha[4];
                novoUsuario.Email = linha[5];
                novoUsuario.Senha = linha[6];

                usuarios.Add(novoUsuario);
            }

            return usuarios;
        }

        public void Update(Usuario u)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}