using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace SistemaNotificacaoBancariaPOO
{
    delegate void NotificacaoAlerta(string mensagemAlerta);
    internal class ContaBancaria
    {
        private string _titular;
        private double _saldo;
        private double _limiteExtra;

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            private set { _saldo = value; }
        }
        public double LimiteExtra
        {
            get { return _limiteExtra; }
            set
            {
                if (value >= 0)
                {
                    _limiteExtra = value;
                }
                else
                {
                    Console.WriteLine("O Limite Extra é inválido por causa que é um valor negativo. Limite = 0");
                    _limiteExtra = 0;
                }
            }
        }

        public ContaBancaria(string titular, double saldo, double limiteExtra)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.LimiteExtra = limiteExtra;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"O dinheiro foi depositado no seu saldo da conta");
        }
        public void Sacar(double valor, NotificacaoAlerta alerta) 
        {
            if (Saldo + LimiteExtra  >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"A retirada do saldo foi concluído com sucesso. O novo valor do Saldo: R${Saldo}");
            }

            if (valor > 1000 || Saldo < 0)
            {
                alerta?.Invoke($"ALERTA: Saque de alto valor ou uso de limite detectado na conta de {Titular}.");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente. \nR${Saldo}");
            }
        }
       
    }
}
