using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;


namespace Mini_Bank
{
    internal class BanqueAccount
    {
        
        private double  Money =0;
        private string  Name;

       public BanqueAccount(double money, string name)
        {
            Money = money;
            this.Name = name;

        }
        public void AddMoney(double amount)
        {
            Money += amount;
       

        }
        public void Subtract(double money)
        {
            this.Money -= money;


        }
        public void GetMoney()
        {
            Console.WriteLine(Name + "has" + Money);
        }


        // Ajout de la méthode getInfo()
        public void GetInfo()
        {
            Console.WriteLine($"{Name} a {Money:C} dans son compte");
        }
        

      }

    

    }
