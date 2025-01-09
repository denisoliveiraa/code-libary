using MyLibary;
using MyClients;
public class Library {
 private List<Book> _book;
 private List<Loan> _loan;
 private List<Client> _client;

    public Library()
    {
       _book = new List<Book>();
       _client = new List<Client>();
       _loan = new List<Loan>();
    }

    public void registerBook(Book livros){
      _book.Add(livros);
    }
    public int CountBooks => _book.Count;
    public int CountClient => _client.Count;
    public void registerLoan(Loan loan){
        Console.WriteLine("Escolha um cliente");
        string res = Console.ReadLine();
        
        _loan.Add(loan);
    }

    public void findClientId(){

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