using System;
using Antares.vendas.ViewController;
using Antares.vendas.ViewModels;

namespace Antares.vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewModels usuarioLogado = new UsuarioViewModels();
            bool flag;

            
            usuarioLogado = UsuarioViewConroller.Login();

            System.Console.WriteLine(usuarioLogado.Nome);

            flag = UsuarioViewConroller.VerificacaoCargo(usuarioLogado);

            if(flag == true){

                System.Console.WriteLine("Usuario é adm");
            }
            else{
                System.Console.WriteLine("Usuario é um merda");
            }
        }
    }
}
