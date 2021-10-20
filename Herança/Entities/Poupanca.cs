using System;
using System.Collections.Generic;
using System.Text;

namespace Herança
{
    class Poupanca : Conta
    {
        //Variáveis e uso do encapsulamento
        public double TaxaJuros { get; set; }

        //Construtor padrão
        public Poupanca()
        {
        }

        //Construtor com parâmetros utilizando a Classe Conta
        public Poupanca(int numero, string titular, double saldo, double taxajuros)
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxajuros;
        }

        //Método de atualização de saldo
        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        //utilizando o método da classe conta através da sobreposição
        public override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= -2;
        }
    }
}
