using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEncapsulamento
{
    internal class Conta
    {
        private string nome;
        private double saldo;
        private string senha;
        private double limite;

        public Conta(string nome, double saldo, string senha)
        {
            this.nome = nome;
            this.saldo = saldo;
            this.senha = senha;
        }
              
     
        public void Depositar(double valor) { saldo = saldo + valor; }
        public void Saque(double valor) { saldo = saldo - valor; }
        public void AlterarLimite(double valor) 
        { 
           if(saldo * 2 > valor)
            {
                limite = valor;
            }
            else
            {
                Console.WriteLine("Não foi possível colocar o limite solicitado! O limite só pode ser até duas vezes o saldo em conta!");
            }
        }
        public override string ToString()
        {
            return $"Nome do Titular: " + nome + "\nSaldo em conta: " + saldo + "\nLimite do cartão de crédito: " + limite;
        }
    }
}
