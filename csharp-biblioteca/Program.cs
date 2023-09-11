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

            Book LeCronacheDiNarnia = new Book("Le Cronache Di Narnia", "04-11-2014", "Fantasy", "Books-B16", "C. S. Lewis", 841);
            Dvd SuperMarioBros = new Dvd("Super Mario Bros - Il Film", "22-06-2023", "Animation", "Dvds-D324", "Nintendo", 1.32);

            List<Document> NewDocument = new List<Document>();
            NewDocument.Add(LeCronacheDiNarnia);
            NewDocument.Add(SuperMarioBros);

            foreach (Document document in NewDocument)
            {
                document.PrintInfo();
            }
        }
    }
}