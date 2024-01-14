using ListaDeCadastro;

internal class Program
{
    private static void Main(string[] args)
    {
        Cadastro cadastro = new Cadastro();
        
        bool programa = true;

        while (programa) {

            Console.WriteLine("Digite uma opção abaixo.");
            Console.WriteLine("1-Adicionar Cliente.");
            Console.WriteLine("2-Remover Cliente.");
            Console.WriteLine("3-Listar Clientes.");
            Console.WriteLine("4-Encerrar o programa.");

            int escolha = Convert.ToInt32(Console.ReadLine());

        if (escolha == 1) {

            Console.WriteLine("Digite o nome do cliente");
            string nomeCliete= Console.ReadLine();
            cadastro.Adicionar(nomeCliete);
                Console.WriteLine($"Cliente {nomeCliete} cadastrado com sucesso.");

            }
            else if (escolha == 2)
        {
            Console.WriteLine("Digite o nome do cliente");
            string nomeCliete = Console.ReadLine();
            cadastro.RemoverCliente(nomeCliete);
                Console.WriteLine($"Cliente {nomeCliete} removido com sucesso.");
            }
            else if (escolha == 3)
        {
            cadastro.ListarClientes();
        }else if (escolha == 4) 
        {
            Console.WriteLine("Obrigado por ultilizar o programa");
                programa= false;
        }
        }
    }
}