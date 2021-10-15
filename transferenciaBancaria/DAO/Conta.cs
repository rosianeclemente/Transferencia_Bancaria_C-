using System;

namespace Transferencia_Bancaria_C_
{
    public class Conta
    {
        private string Nome { get; set; }
        private double Credito { get; set; }
        private double Saldo { get; set; }
        private TipoConta TipoConta { get; set; }

        public Conta (TipoConta tipoConta, double credito, double saldo, string nome){
            this.Credito = credito;
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Nome = nome;
        }
        public bool Sacar(double valorSaque){
            if(this.Saldo - valorSaque < (this.Credito *-1)){
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Salado atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }
        public void Depositar(double valorDepositar){
            this.Saldo += valorDepositar;
            Console.WriteLine("Salado atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }
        public void Transferir(double valorTransferir, Conta contaDestino){
            if(this.Sacar(valorTransferir)){
                contaDestino.Depositar(valorTransferir);
            }
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito;
            return retorno;
        }
    }
    
}