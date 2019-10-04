using System;
using Herança.Entities;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "RafaelSantos", 100.00, 500.0);//´número da conta(Number),Titular(Holder),Saldo da conta(Balance),limite de saque
            Console.WriteLine(account.Balance);
            //account.Balance=200.00; Caso colocar essevalor nesse atributo irá dar erro,porque ele não é acessivel para modificalo com protected
            
        }
    }
}
