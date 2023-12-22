internal class Program
{
    private static void Main(string[] args)
    {
        bool playAgain = true;
        //enquanto true joga novamente
        while (playAgain)
        {
            string escolhaJogador = "";
            string escolhaMaq = "";
            Random random = new Random();
            
            switch (random.Next(1, 4)){
                case 1:
                    escolhaMaq = "PEDRA";
                    break;
                case 2:
                    escolhaMaq = "PAPEL";
                    break;
                case 3:
                    escolhaMaq = "TESOURA";
                    break;
            }
            //ESCOLHA MAQUINA
            while (escolhaJogador != "PEDRA" && escolhaJogador != "PAPEL" && escolhaJogador!="TESOURA")
            {
                Console.WriteLine("Escolha pedra, papel ou tesoura:");
                 escolhaJogador = Console.ReadLine();
                escolhaJogador = escolhaJogador.ToUpper();
                
            }
            //ESCOLHA JOGADOR

            Console.WriteLine("Você escolheu " + escolhaJogador);
            Console.WriteLine("A maquina escolheu " + escolhaMaq);

            switch (escolhaJogador)
            {
                case "PEDRA":
                    if (escolhaMaq == "PEDRA")
                    {
                        Console.WriteLine("Você empatou com a maquina!");
                    }else if (escolhaMaq == "PAPEL")
                    {
                        Console.WriteLine("Você ganhou da máquina!");
                    }else if (escolhaMaq == "TESOURA")
                    {
                        Console.WriteLine("Você perdeu da maquina!");
                    }
                    break;

                case "PAPEL":
                    if (escolhaMaq == "PEDRA")
                    {
                        Console.WriteLine("Você ganhou da maquina!");
                    }
                    else if (escolhaMaq == "PAPEL")
                    {
                        Console.WriteLine("Você empatou com a máquina!");
                    }
                    else if (escolhaMaq == "TESOURA")
                    {
                        Console.WriteLine("Você perdeu da maquina!");
                    }
                    break;

                case "TESOURA":

                    if (escolhaMaq == "PEDRA")
                    {
                        Console.WriteLine("Você perdeu da maquina!");
                    }
                    else if (escolhaMaq == "PAPEL")
                    {
                        Console.WriteLine("Você ganhou da máquina!");
                    }
                    else if (escolhaMaq == "TESOURA")
                    {
                        Console.WriteLine("Você empatou com a maquina!");
                    }
                    break;
            }

            Console.WriteLine("Você deseja jogar novamente?(Y/N)");
            string reestart =Console.ReadLine();
            reestart = reestart.ToUpper();

            if (reestart == "N")
            {
                playAgain = false;
            }
            //JOGAR NOVAMENTE?

            

        }
        Console.WriteLine("Obrigado por jogar!");

    }
}