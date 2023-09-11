namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
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