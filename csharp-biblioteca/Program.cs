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

            Book LeCronacheDiNarnia = new Book("Narnia", "04-11-2014", "books", "Books-B16", "C. S. Lewis", 841);
            Dvd SuperMarioBros = new Dvd("Super Mario", "22-06-2023", "dvds", "Dvds-D324", "Nintendo", 1.32);

            

            Library library = new Library();
            

            library.AddDocumentInLibrary(LeCronacheDiNarnia);
            library.AddDocumentInLibrary(SuperMarioBros);
            library.AddUserInLibrary(newUser);

            foreach(var item in library.Documents)
            {
                Console.WriteLine(item.identificationCode);
            }


            while (true)
            {
                Console.WriteLine("What do you have to do? |sd = search document | sc= Search By Code | exit = close window");
                string choice = Console.ReadLine();
                if (choice == "sd" ||  choice == "SD" ) 
                {
                    Console.WriteLine($"Hi {newUser.name}");

                    Console.WriteLine("Find the document that u need: ");

                    string title = Console.ReadLine();

                    Document doc = library.FindByTitle(title);

                    if (doc != null)
                    {
                        Console.WriteLine($"Here is your document: {doc.title}, you can find it in the shelf: {doc.position} in section: {doc.type}");
                    } else
                    {
                        Console.WriteLine($"We haven't this document :(");
                    }

                } else if (choice == "sc" || choice == "SC") 
                {
                    Console.WriteLine($"Hi {newUser.name}");

                    Console.Write($"What document u need?");

                    string code = Console.ReadLine();

                    Document doc = library.FindByCode(code);

                    if (doc != null) 
                    {
                        Console.WriteLine($"Here is your document: {doc.title} code: {doc.identificationCode}, you can find it in the shelf: {doc.position} in section: {doc.type}");
                    } else
                    {
                        Console.WriteLine($"We haven't this document :(");
                    }
                }
                else if(choice == "exit" || choice == "e") 
                {
                    break;
                }
            }
        }
    }
}