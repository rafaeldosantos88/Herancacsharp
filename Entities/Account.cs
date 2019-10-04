using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Entities
{
    class Account     //Criado classe conta
    {
        public int Number { get; private set; } //Com uso do private esses dados vão ser acessados mais não alterados
        public string  Holder { get; private set; } //Titular da conta
        public double Balance { get; protected set; }//Saldo da Conta

        public Account()                  //Construtor padrão
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amount) //Operaçãosaque(withdraw) recebendo uma quantia(amount) como parametro de entrada.Essa quantia vai ser retirada do   Balance(Saldo da conta)que é sacar.
        {
            Balance -= amount;             //Saldo da conta menos(-)quantia

        }
        public void Deposit(double amount) //Esse deposito vai receber uma quantia
        {
            Balance += amount;             //Esse deposito vai pegar saldo e acrescentar uma quantia

        }
        
    }
}
