using System.Dynamic;
using System.Formats.Asn1;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


// Пара_1


/*
Robot titan_bt = new Robot("BT_7274", "1", 1, "Авангард");
Robot droid_r2d2 = new Robot("R2D2", "156", 41, "Астрадроид");

titan_bt.Model = "13";

titan_bt.ShowInfo();
droid_r2d2.ShowInfo();

public class Robot
{
    public string Name;
    public string Model;
    public int SerialNumber;
    public string Type;

    public Robot(string name, string model, int serialnumber, string type)
    {
        this.Name = name;
        this.Model = model;
        this.SerialNumber = serialnumber;
        this.Type = type;
    }

    public void ShowInfo()
    {
        Console.Write($"\t My name: {this.Name}\n" +
        $"\t My model: {this.Model}\n" +
        $"\t My serial number: {this.SerialNumber}\n" +
        $"\t Me type: {this.Type}\n\nn");
    }
}


// Пара_2


// Robot droidR2D2 = new Robot("R2D2", "Astradroid", 1023);

// Console.WriteLine(droidR2D2.SerialNumber);

// Console.WriteLine(droidR2D2.RobotName);

// Задание_1

Robot jamesBond = new Robot("spy");

Console.WriteLine(jamesBond.Model);

public class Robot
{
    private string _model;

    public string Model
    {
        get
        {
            if (_model == "spy")
            {
                string[] models = { "Doctor", "Police man", "Programmer" };
                Random rnd = new Random();
                int rndId = rnd.Next(0, models.Length);
                return models[rndId];
            }
            return _model;
        }
    }

    public Robot(string model)
    {
        _model = model;
    }
}

public class Robot
{
    // Вариант_1

    private string _robotName;
    public string RobotName => _robotName;

    public void SetName(string name)
    {
        _robotName = name;
    }

    // Вариант_2

    public string Model { get; private set; }

    // Вариант_3

    private int _serialNumber;

    public int SerialNumber
    {
        get { return _serialNumber; }
        set
        {
            if (value > 1000)
            {
                _serialNumber = 1;
            }
            else
            {
                _serialNumber = value;
            }
        }
    }

    public Robot(string name, string model, int serialnumber)
    {
        _robotName = name;
        Model = model;
        SerialNumber = serialnumber;
    }
}


// Пара_3

namespace Pr_0
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Person personEnaken = new Person("Енакен", "Скайвокер", 34);
            personEnaken.ShowInfo();

            Employee employeeLuc = new Employee("Люк", "Скайвокер", 21, 1300, "Пилот сопротивления");
            employeeLuc.ShowInfo();

            Developer developerLin = new Developer("Лин", "Скайвокер", 21, 1300, "Пилот сопротивления", "1", "Джедай");
            developerLin.ShowInfo();
        }
        public class Person
        {
            private string _firstname;
            private string _lastname;
            private int _age;

            public string Firstname => _firstname;
            public string Lastname => _lastname;
            public int Age
            {
                get { return _age; }
                set
                {
                    if (value > 70)
                    {
                        _age = 1;
                    }
                    else
                    {
                        _age = value;
                    }
                }
            }



            public Person(string firstname, string lastname, int age)
            {
                _firstname = firstname;
                _lastname = lastname;
                _age = age;
            }

            protected string GenerateInfo()
            {
                return $"Имя: {_firstname}\n" + $"Фамилия: {_lastname}\n" + $"Возраст: {_age}\n";
            }

            public void ShowInfo()
            {
                Console.WriteLine(GenerateInfo());
            }
        }

        public class Employee : Person
        {
            private int _salary;
            private string _position;

            public int Salary
            {
                get { return _salary; }
                set
                {
                    if (value > 10000)
                    {
                        _salary = 1;
                    }
                    else
                    {
                        _salary = value;
                    }
                }
            }

            public string Position => _position;

            public Employee(string firstname, string lastname, int age, int salary, string position) : base(firstname, lastname, age)
            {
                _salary = salary;
                _position = position;
            }

            protected string GenerateInfo()
            {
                return base.GenerateInfo() + $"Зарплата: {_salary}$\n" + $"Должность: {_position}\n";
            }

            public void ShowInfo()
            {
                Console.WriteLine(GenerateInfo());
            }
        }

        public class Developer : Employee
        {
            private string _pl;
            private string _level;

            public string Pl => _pl;
            public string Level => _level;

            public Developer(string firstname, string lastname, int age, int salary, string position, string pl, string level) : base(firstname, lastname, age, salary, position)
            {
                _pl = pl;
                _level = level;
            }

            protected string GenerateInfo()
            {
                return base.GenerateInfo() + $"Язык: {_pl}\n" + $"Уровень: {_level}\n";
            }

            public void ShowInfo()
            {
                Console.WriteLine(GenerateInfo());
            }
        }
    }
}

*/

// КТ_1


namespace Pr_0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] books = { "Хребты безумия", "Зов Ктулху", "Деагон" };

            Library library = new Library("Храм Джедаев, 1", books);

            Reader readerEnaken = new Reader("Энакен", "Скайуокер", 19);

            readerEnaken.ReadBook(library, "Хребты безумия");
            readerEnaken.ReadBook(library, "Ненайденная книга");
        }
    }
}         