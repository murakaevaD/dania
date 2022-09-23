using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Student
    {
        public string name;
        public string surname;
        public int id;
        public string birthday;
        public string category;
        public int AlkoVolume;
        public Student(string name, string surname, int id, string birthday, string category, int AlkoVolume)
        {
            this.name = name;
            this.surname = surname;
            this.id = id;
            this.birthday = birthday;
            this.category = category;
            this.AlkoVolume = AlkoVolume;
        }
        public void Print()
        {
            Console.WriteLine($"Имя:{name}, Фамилия:{surname}, Идентификатор:{id}, Дата рождения:{birthday}, Категория алкоголизма:{category}, Объём выпитого:{AlkoVolume}");
        }

    }
    struct User
    {
        public string Name;
        public int age;
        public string city;
        public int pin;
        public User(string Name, int age, string city, int pin)
        {
            this.Name = Name;
            this.age = age;
            this.city = city;
            this.pin = pin;
        }
        public void Print2()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {age}, Город: {city}, pin: {pin}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("НОМЕР 1 СТРУКТУРА СТУДЕНТА");
            Student student1 = new Student();
            student1.name = "Алина";
            student1.surname = "Листопадова";
            student1.id = 1;
            student1.birthday = "29.01.2004";
            student1.category = "b";
            student1.AlkoVolume = 2;
            student1.Print();
            Student student2 = new Student();
            student2.name = "Лера";
            student2.surname = "Сабирова";
            student2.id = 2;
            student2.birthday = "23.07.2005";
            student2.category = "d";
            student2.AlkoVolume = 0;
            student2.Print();
            Student student3 = new Student();
            student3.name = "Камилла";
            student3.surname = "Хабибуллина";
            student3.id = 3;
            student3.birthday = "22.04.2004";
            student3.category = "a";
            student3.AlkoVolume = 10;
            student3.Print();
            Student student4 = new Student();
            student4.name = "Ильдар";
            student4.surname = "Енилеев";
            student4.id = 4;
            student4.birthday = "03.10.2004";
            student4.category = "b";
            student4.AlkoVolume = 5;
            student4.Print();
            Student student5 = new Student();
            student5.name = "Миша";
            student5.surname = "Курлычкин";
            student5.id = 5;
            student5.birthday = "15.05.2004";
            student5.category = "с";
            student5.AlkoVolume = 1;
            student5.Print();
            double volume = student1.AlkoVolume + student2.AlkoVolume + student3.AlkoVolume + student4.AlkoVolume + student5.AlkoVolume;
            Console.WriteLine($"Первый студент выпил: {Math.Round((student1.AlkoVolume / volume) * 100, 1)}%" + "\n" +
           $"Второй студент выпил: {Math.Round((student2.AlkoVolume / volume) * 100, 1)}%" + "\n" +
           $"Третий студент выпил: {Math.Round((student3.AlkoVolume / volume) * 100, 1)}%" + "\n" +
           $"Четвёртый студент выпил: {Math.Round((student4.AlkoVolume / volume) * 100, 1)}%" + "\n" +
           $"Пятый студент выпил: {Math.Round((student5.AlkoVolume / volume) * 100, 1)}%" + "\n" + $"Общий объём алкоголя: {volume}");

            Console.WriteLine("НОМЕР 2 ТИПЫ ДАННЫХ");
            Console.WriteLine("Целочисленные типы: " + "\n" +
            $"byte: {byte.MinValue} - {byte.MaxValue}" + "\n" +
            $"sbyte: {sbyte.MinValue} - {sbyte.MaxValue}" + "\n" +
            $"short: {short.MinValue} - {short.MaxValue}" + "\n" +
            $"ushort: {ushort.MinValue} - {ushort.MaxValue}" + "\n" +
            $"int: {int.MinValue} - {int.MaxValue}" + "\n" +
            $"uint: {uint.MinValue} - {uint.MaxValue}" + "\n" +
            $"long: {long.MinValue} - {long.MaxValue}" + "\n" +
            $"ulong: {ulong.MinValue} - {ulong.MaxValue}" + "\n" +
            "Типы с плавающей точкой: " + "\n" +
            $"float: {float.MinValue} - {float.MaxValue}" + "\n" +
            $"double: {double.MinValue} - {double.MaxValue}" + "\n" +
            $"decimal: {decimal.MinValue} - {decimal.MaxValue}" + "\n" +
            "Тип bool и тип char: " + "\n" +
            "char: служит для представления символьных значений" + "\n" +
            "bool: true - false");

            Console.WriteLine("НОМЕР 3 ДАННЫЕ ПОЛЬЗОВАТЕЛЯ");
            User user1 = new User();
            Console.Write("Введите имя: ");
            user1.Name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            user1.age = int.Parse(Console.ReadLine());
            Console.Write("Введите город: ");
            user1.city = Console.ReadLine();
            Console.Write("Введите pin: ");
            user1.pin = int.Parse(Console.ReadLine());
            user1.Print2();

            Console.WriteLine("НОМЕР 4 ИМЯ В ИНИЦИАЛЫ");
            Console.Write("Введите имя и фамилию через пробел: ");
            string[] ini = Console.ReadLine().Split(' ');
            Console.WriteLine($"{ini[0][0].ToString().ToUpper()}.{ini[1][0].ToString().ToUpper()}");

            Console.WriteLine("НОМЕР 5 СКОЛЬКО ВИСКИ КУПИТЬ");
            Console.Write("Введите стандартную цену виски: ");
            int normPrice = int.Parse(Console.ReadLine());
            Console.Write("Введите скидку в DutyFree в %: ");
            int salePrice = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость отпуска: ");
            int holidayPrice = int.Parse(Console.ReadLine());
            double che = salePrice * normPrice * 0.01;
            double am1 = holidayPrice / che;
            double am2 = Math.Floor(am1);
            Console.WriteLine("Нужно купить " + am2 + " бутылок");

            Console.WriteLine("НОМЕР 6 СКОРОСТЬ ТАРАКАНА");
            Console.Write("Введите скорость в км/ч: ");
            double speed = double.Parse(Console.ReadLine());
            double sped = (speed * 100000) / 3600;
            Console.WriteLine($"Скорость в см/сек равна: {Math.Floor(sped)}");

            Console.WriteLine("НОМЕР 7 ПРЕОБРАЗОВАНИЕ ВХОДНОЙ СТРОКИ");
            Console.Write("Введите слово: ");
            string clovo = Console.ReadLine();
            StringBuilder lovo = new StringBuilder();
            foreach (Char c in clovo.ToCharArray())
            {
                if (Char.IsLower(c))
                {
                    lovo.Append(Char.ToUpper(c));
                }
                else
                {
                    lovo.Append(Char.ToLower(c));
                }
            }
            Console.WriteLine(lovo);
            Console.ReadKey();
        }
    }
}
