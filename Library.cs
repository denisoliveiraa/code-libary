using MyLibary;
using MyClients;
public class Library {
 private List<Book> _book;
 private List<Client> _client;

    public Library()
    {
       _book = new List<Book>();
       _client = new List<Client>();
    }

    public void registerBook(Book livros){
      _book.Add(livros);
    }

    public void ShowBooks()
        {
            foreach (var book in _book)
            {
                Console.WriteLine($"Nome: {book.title}, Autor: {book.authorName}, Ano: {book.publisherYear}");
            }
        }

         public void ShowClients()
        {
            foreach (var client in _client )
            {
                Console.WriteLine($"Nome: {client.name}, Sobrenome: {client.lastName}, Ano Nascimento: {client.yearBirth}");
            }
        }

            public void registerClient(Client client)
            {
               _client.Add(client);
            }

}