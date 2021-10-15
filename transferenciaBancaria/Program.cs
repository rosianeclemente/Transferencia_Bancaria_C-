using System;

namespace Transferencia_Bancaria_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1":
                        // ListarContas();
                        break;
                    case "2":
                        // InserirConta();
                        break;
                    case "3":
                        // Transferir();
                        break;
                    case "4":
                        // Sacar();
                        break;
                    case "5":
                        // Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por  utilizar nossos serviços");
            Console.ReadLine();
        }

        

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Dio Bank a seu Dipor!!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2-Inseir nova conta");
            Console.WriteLine("3-Transferir");
            Console.WriteLine("4-Sacar");
            Console.WriteLine("5-Depositar");
            Console.WriteLine("C- limpar Tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
