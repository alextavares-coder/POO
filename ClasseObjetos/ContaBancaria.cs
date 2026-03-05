using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObjetos
{
    public class ContaBancaria
    {
        #region Atributos
        public string titular;
        public double saldo;
        public int numeroConta;
        #endregion

        #region Construtor
        public ContaBancaria(string titular, int numeroConta)
        {
            this.titular = titular;
            this.numeroConta = numeroConta;
            this.saldo = 0; //Conta Zerada
        }
        #endregion
    

    #region Métodos
     public void Depositar(double valor)
    {
            saldo += valor;
    }

        public void Sacar(double valor)
        {
            if(valor <= saldo) saldo -= valor;

            //if (valor <= saldo)
            //{
            //    saldo -= valor;
            //}
        }

    public void ExibirSaldo()
        {
            Console.WriteLine($"Conta Nº: {numeroConta} | Titular: {titular} | Saldo: {saldo:c2} em {DateTime.Now: dd/MM/yyyy}");
        }
    #endregion
    }
}
