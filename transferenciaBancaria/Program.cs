using System;
using System.Collections.Generic;

namespace Transferencia_Bancaria_C_
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1":
                         ListarContas();
                        break;
                    case "2":
                         InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
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

        private static void Depositar()
        {
           Console.Write("Digite o numero da conta: ");
           int indiceConta = int.Parse(Console.ReadLine());

           Console.Write("Digite o valor a ser depositado: ");
           double valorDepositao = double.Parse(Console.ReadLine());

           listContas[indiceConta].Depositar(valorDepositao);
            
        }

        private static void Transferir()
        {
            Console.Write("Digite o numero da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valortransferido = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valortransferido, listContas[indiceContaDestino]);
            
        }

        private static void Sacar()
        {
            Console.Write("Digite o numero da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorDepositado = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorDepositado);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas: ");
           if( listContas.Count == 0){
               Console.WriteLine("Nenhum conta cadastrada.");
               return;
           }
           for (int i = 0; i < listContas.Count; i++){
               Conta conta = listContas[i];
               Console.Write("#{0} -", i);
               Console.WriteLine(conta);
           }
        }

        private static void InserirConta()
        {
           Console.WriteLine("Inserir nova Conta: ");
           Console.Write("Digite 1 para conta Fisica ou 2 para juridica: ");
           int entradaTipoConta = int.Parse(Console.ReadLine());

           Console.Write("Digite o Nome do Cliente: ");
           string entradaNome = Console.ReadLine(); 

           Console.Write("Digite o Saldo: ");
           double entradaSaldo = double.Parse(Console.ReadLine());

           Console.Write("Digite o credito: ");
           double entradaCredito = double.Parse(Console.ReadLine());

           Conta novaConta = new Conta (tipoConta: (TipoConta)entradaTipoConta,
           saldo: entradaSaldo, credito: entradaCredito, nome: entradaNome);

           listContas.Add(novaConta);
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
