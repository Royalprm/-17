using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_17
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        
        BankAccount<int> ba1 = new BankAccount<int>("Сергей", 150150, 50);
        ba1.GetInfo();
            ba1.SetName("Михаил"); 
            ba1.SetBill(1500); 
            ba1.GetInfo();

            
            
            BankAccount<string> ba2 = new BankAccount<string>("Иван", "150151", 0);
        ba2.GetInfo();
            ba2.AddMoney(155.5); 
            ba2.GetInfo();

            
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        
        T BankNum { get; set; }
        double Bill { get; set; }
        string UserName { get; set; }

        
        public BankAccount(string userName, T bankAccount, double bill)
        {
            UserName = userName;
            BankNum = bankAccount;
            Bill = bill;
        }

        
        public void SetName(string userName) 
        {
            UserName = userName;
        }
        public void SetBill(double bill) 
        {
            Bill = bill;
        }
        public void AddMoney(double money) 
        {
            Bill += money;
        }

        
        public void GetInfo()
        {
            Console.WriteLine("Информация о банковском аккаунте:");
            Console.WriteLine($"Пользователь: {UserName}");
            Console.WriteLine($"Банковский аккаунт: {BankNum}");
            Console.WriteLine($"Счет: {Bill}$\n");
        }

    }
}

