using System;
using System.Collections.Generic;
using System.Text;

namespace Herança
{
    class ContaJuridica : Conta
    {
        //Variáveis e uso do encapsulamento
        public double EmprestimoLimite { get; set; }

        //Construtor padrão

        public ContaJuridica()
        {
        }

        //Construtor com parâmetros utilizando a Classe Conta
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite)
            : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        //Método de empréstimo
        public void Emprestimo(double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    } 
}
