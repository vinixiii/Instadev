using System;
using System.Collections.Generic;
using System.IO;
using Instadev_06.Interfaces;

namespace Instadev_06.Models
{
    public class Comentario : InstadevBase, IComentario
    {
        public int IdComentario { get; set; }

        public string Mensagem { get; set; }

        public int IdUsuario { get; set; }

        public int IdPublicacao { get; set; }

        public const string PATH = "Database/Comentario.csv";

        public string _PATH
        {
            get { return PATH; }
        }

        public Comentario()
        {
            //Cria a pasta e o arquivos caso ainda não esteja criado
            CreateFolderAndFile(PATH);
        }

        public string PrepareLineCSV(Comentario c)
        {
            //Transforma o objeto Publicação em uma linha de arquivo CSV
            return $"{c.IdComentario};{c.Mensagem};{c.IdUsuario};{c.IdPublicacao}";
        }

        // Implementado a Interface com o CRUD

        public void Create(Comentario c)
        {
            string[] linhas = {PrepareLineCSV(c)};

            File.AppendAllLines(PATH, linhas);
        }

        public void Delete(int id)
        {
            //Lemos todas as linhas do CSV
            List<string> linhas = ReadAllLinesCSV(PATH);

            //Removemos as linhas com o id comparado
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());

            //Reescrevemos o csv com a lista alterada
            RewriteCSV(PATH, linhas);
        }

        public List<Comentario> ReadAll()
        {
            List<Comentario> comentarios = new List<Comentario>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] linha = item.Split(";");

                Comentario novoComentario = new Comentario();
                novoComentario.IdComentario = int.Parse(linha[0]);
                novoComentario.Mensagem = linha[1];
                novoComentario.IdUsuario = int.Parse(linha[2]);
                novoComentario.IdPublicacao = int.Parse(linha[3]);
                
                comentarios.Add(novoComentario);
            }

            return comentarios;
        }

        public void Update(Comentario c)
        {
            //Lemos todas as linhas do CSV
            List<string> linhas = ReadAllLinesCSV(PATH);

            //Removemos as linhas com o código comparado
            // Nesse caso o usuário só consegue alterar o seu comentario
            linhas.RemoveAll(x => x.Split(";")[0] == c.IdComentario.ToString());

            //Adicionamos a lista alterada
            linhas.Add(PrepareLineCSV(c));

            //Reescrevemos o csv com a lista alterada
            RewriteCSV(PATH, linhas);
        }
    }


}