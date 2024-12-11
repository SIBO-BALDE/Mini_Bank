using System;

namespace Mini_Bank // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BanqueAccount bankaccount = new BanqueAccount(money: 100, name: "Sibo Balde");
            bankaccount.AddMoney(amount: 50);
            bankaccount.GetInfo();
            bankaccount.Subtract(money: 10);
            bankaccount.GetInfo();
        }
    }
}
