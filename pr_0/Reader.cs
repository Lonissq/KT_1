
namespace Pr_0
{
    public class Reader : Person
    {
        public Reader(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public void ReadBook(Library library, string booktitle)
        {
            bool found = false;

            foreach (string book in library.Books)
            {
                if (book == booktitle)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"Reader {Firstname} {Lastname} прочитал книгу \"{booktitle}\".");
            else
                Console.WriteLine($"Книга \"{booktitle}\" не найдена в библиотеке.");
        }
    }
}         