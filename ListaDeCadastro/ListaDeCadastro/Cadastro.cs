using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCadastro
{
    internal class Cadastro
    {
        List <string> clientes = new List <string> ();

        public void Adicionar(string cliente)
        {
            clientes.Add(cliente);
        }

        public void ListarClientes()
        {
            foreach(string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
        }

        public void RemoverCliente(string nome)
        {
            clientes.Remove(nome);
        }
        

    }
}
