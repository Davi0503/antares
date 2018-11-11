using System;
using System.Collections.Generic;
using System.IO;
using Antares.vendas.Repositorio;
using Antares.vendas.ViewModels;
namespace Antares.vendas.ViewController {
    public class UsuarioViewConroller {
        public static void CadastrarUsuario () {

            string nome, senha, cargo;
            int contador = 0;

            do {
                System.Console.WriteLine ("Informe o nome do usuário.");
                nome = Console.ReadLine ();

            } while (string.IsNullOrEmpty (nome));

            System.Console.WriteLine ("Informe a senha para o Usuário");
            senha = Console.ReadLine ();

            System.Console.WriteLine ("O usuário vai ser administrador ?");
            cargo = Console.ReadLine ();

            List<UsuarioViewModels> lsUsuario = Listar ();

            if (lsUsuario != null) {

                contador = lsUsuario.Count;

            }
            UsuarioViewModels usuario = new UsuarioViewModels ();

            usuario.ID = contador + 1;
            usuario.Nome = nome;
            usuario.Senha = senha;
            usuario.Cargo = cargo;

            UsuarioRepositorio.Inserir(usuario);

            //Falta inserir no repositorio para salvar no banco de dados

        }

        public static List<UsuarioViewModels> Listar () {

            List<UsuarioViewModels> lsUsuario = new List<UsuarioViewModels> ();

            UsuarioViewModels usuario;

            string[] usuariosArray = File.ReadAllLines (@"banco_de_dados/Usuarios.csv");

            foreach (string item in usuariosArray) {

                string[] dadosUsuario = item.Split (";");

                usuario = new UsuarioViewModels ();

                usuario.ID = int.Parse (dadosUsuario[0]);
                usuario.Nome = dadosUsuario[1];
                usuario.Senha = dadosUsuario[2];
                usuario.Cargo = dadosUsuario[3];
                lsUsuario.Add (usuario);
            }

            return lsUsuario;

        }

        public static UsuarioViewModels Login (){
            int id;
            string senha;
            List<UsuarioViewModels> lsUsuario = Listar();
            UsuarioViewModels usuario = new UsuarioViewModels();

            System.Console.WriteLine("Insira seu ID");
            id = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Inisira sua senha");
            senha = Console.ReadLine();           

            foreach (UsuarioViewModels item in lsUsuario)
            {
                if(item.ID == id && item.Senha == senha){

                    Console.Clear();

                    System.Console.WriteLine($"Seja bem vindo {item.Nome}");

                    Console.ReadKey();
                    return usuario;
                }
            }
            
            return null;     

        }


        public static bool VerificacaoCargo (UsuarioViewModels usuario){

            bool flag;

            if(usuario.Cargo =="ADM"){

                flag = true;
                
            }else{
                flag = false;
            }
            return flag;
        }




    }
}