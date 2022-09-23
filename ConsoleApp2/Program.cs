using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum Bank_Account
    {
        Текущий,
        Cберегательный
    }
    struct bank
    {
        public int numb;
        public string type;
        public int balance;
        public bank(int numb, string type, int balance)
        {
            this.numb = numb;
            this.type = type;
            this.balance = balance;
        }
        public void Print()
        {
            Console.WriteLine($"Номер: {numb}, Тип: {type}, Баланс: {balance}");
        }
    }
    enum vuz
    {
        КГУ, КАИ, КХТИ,
    }
    struct Worker
    {
        public string NAME;
        public string vuz;
        public Worker(string NAME, string vuz)
        {
            this.NAME = NAME;
            this.vuz = vuz;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {NAME}, Вуз: {vuz}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            Bank_Account Account = new Bank_Account();
            Account = Bank_Account.Текущий;
            Console.WriteLine(Account);

            Console.WriteLine("Упражнение 3.2");
            bank vber = new bank();
            vber.numb = 56;
            vber.type = "Сберегательный";
            vber.balance = 100;
            vber.Print();

            Console.WriteLine("ДЗ 3.1");
            Worker worker1 = new Worker();
            worker1.NAME = "Петруша";
            worker1.vuz = "КГУ";
            worker1.Print();
            Worker worker2 = new Worker();
            worker2.NAME = "Елена";
            worker2.vuz = "КАИ";
            worker2.Print();
            Worker worker3 = new Worker();
            worker3.NAME = "Инокентий";
            worker3.vuz = "КХТИ";
            worker3.Print();
        }
    }
}
