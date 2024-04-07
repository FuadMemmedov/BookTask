using Core.Models;

namespace LibaryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            string choice;
            do
            {
                Console.WriteLine("1.Kitab elave et\n" +
                    "2.Butun kitablara bax\n" +
                    "3.Kitab adina gore axtaris et\n" +
                    "4.Kitab sil\n" +
                    "5.Kitabin adina,yazicisina ve sefihesinin sayina gore axtaris et\n" +
                    "0.Programdan cixin");
                Console.Write("Bir secim edin: ");
                choice = Console.ReadLine();
                if(choice == "1")
                {
                    Console.Write("Kitabin adin daxil edin: ");
                    string name = Console.ReadLine();
                    Console.Write("Kitabin yazicisinin adin daxil edin: ");
                    string authorName = Console.ReadLine();
                    int pageCount;
                    do
                    {
                        Console.Write("Kitabin sefihesinin sayini daxil edin: ");


                    } while (!int.TryParse(Console.ReadLine(),out pageCount));

                    Book book = new Book(name,authorName,pageCount);

                    library.AddBook(book);

                }
                if(choice == "2")
                {
                    foreach(var item in library.GetAllBooks())
                    {
                        item.ShowInfo();
                    }
                }
                if(choice == "3")
                {
                    Console.Write(" Axtarmaq istediyiniz kitabin adin daxil edin: ");
                    string bookName = Console.ReadLine();
                    foreach(var item in library.FindAllBooksByName(bookName))
                    {
                        item.ShowInfo();
                    }

                }
                if(choice == "4")
                {
                    Console.Write(" Silmek istediyiniz kitabin adin daxil edin: ");
                    string bookName = Console.ReadLine();
                    foreach (var item in library.RemoveAllBooksByName(bookName))
                    {
                        item.ShowInfo();
                    }
                }
                if(choice == "5")
                {
                    Console.Write(" Axtarmaq istediyiniz kitabin adin daxil edin: ");
                    string bookName = Console.ReadLine();
                    Console.Write("Axtarmaq istediyinoz kitabin yazicisinin adin daxil edin: ");
                    string authorName = Console.ReadLine();
                    int pageCount;
                    do
                    {
                        Console.Write("Axtarmaq istediyiniz kitabin sefihesinin sayini daxil edin: ");


                    } while (!int.TryParse(Console.ReadLine(), out pageCount));
                    
                    foreach(var item in library.SearchBooks(bookName, authorName, pageCount))
                    {
                        item.ShowInfo();
                    }

                }

            } while (choice != "0");
        }
    }
}
