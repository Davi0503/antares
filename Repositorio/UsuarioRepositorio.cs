using System.IO;
using Antares.vendas.ViewModels;

namespace Antares.vendas.Repositorio {
    public class UsuarioRepositorio {
        public static void Inserir (UsuarioViewModels usuario) {

            StreamWriter sw = new StreamWriter (@"banco_de_dados\Usuarios.csv", true);

            sw.WriteLine ($"{usuario.ID};{usuario.Nome};{usuario.Senha};{usuario.Cargo};");
            sw.Close ();

        }
    }
}