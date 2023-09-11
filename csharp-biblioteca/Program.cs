namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User("Stefano", "Martino", "*******", "emailfasulla@gmail.com", "3381234567");

            Console.WriteLine($"Hi {newUser.name}, and welcome in the biggest library in c# languages!!");
            Console.WriteLine();

            Console.WriteLine("Below you will find some of the documents in our library");
            Console.WriteLine();

            Book LeCronacheDiNarnia = new Book("Narnia", "04-11-2014", "Fantasy", "Books-B16", "C. S. Lewis", 841);
            Dvd SuperMarioBros = new Dvd("Super Mario", "22-06-2023", "Animation", "Dvds-D324", "Nintendo", 1.32);

            Library library = new Library();

            library.AddDocumentInLibrary(LeCronacheDiNarnia);
            library.AddDocumentInLibrary(SuperMarioBros);


            while (true)
            {
                Console.WriteLine("What do you have to do? s = search document");
                string choice = Console.ReadLine();
                if (choice == "s" ||  choice == "S" ) 
                {
                    Console.WriteLine("Find the document that u need: ");
                    string title = Console.ReadLine();
                    Document doc = library.FindByTitle(title);
                    if (doc != null)
                    {
                        Console.WriteLine($"Here is your document: {doc.title}");
                    } else
                    {
                        Console.WriteLine($"We haven't this document :(");
                    }
                }
            }
        }
    }
}