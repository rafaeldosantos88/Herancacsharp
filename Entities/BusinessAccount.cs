using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Entities
{
    class BusinessAccount :Account  //Classe Conta de negocios(Conta empresa). :Os dois pontos significa Herança,ou seja Herda
    {
        public double  LoanLimit { get; set; }

        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance,double loanlimit):base(number,holder,balance) //Para fazer aproveitamento da sobrecarga foi usado  ":base" com os demais parametros
        {
            LoanLimit = loanlimit;
        }
        public void Loan(double amount) //Metodo Loan(Emprestimo) recebendo amount(quantia)
        {
            if (amount <= LoanLimit)//A conta para empresa tem um limite para emprestimo então vou testar se essa quantia que estou emprestando se ela é menor ou igual limite do emprestimo
            {
            Balance += amount;    //Quando a gente empresta esse dinheiro vai cair na conta então vou ter que acrecentar essa quantia no saldo da conta
            }
        }


    }
}
