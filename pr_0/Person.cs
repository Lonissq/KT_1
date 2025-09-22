namespace Pr_0
{
    public class Person
    {
        private string _firstname;
        private string _lastname;
        private int _age;

        public string Firstname => _firstname;
        public string Lastname => _lastname;

        public int Age
        {
            get => _age;
            set
            {
                if (value > 0 && value < 70)
                {
                    _age = value;
                }
                else
                {
                    _age = 0; 
                }
            }
        }

        public Person(string firstname, string lastname, int age)
        {
            _firstname = firstname;
            _lastname = lastname;
            Age = age; 
        }
    }
}