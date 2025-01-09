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

    public Boolean FindBook(int id){
        Book result = _book.Find(b => b.id == id);
        if(result == null || result.available == false){
            Console.WriteLine("Livro não existe ou não está disponível. Escolha um novo livro");
            return true;
        }else{
            result.available = false;
            return false;
        }


    }

    public Boolean FindClient(int id){
        Client result = _client.Find(b => b.id == id);
        if(result == null ){
            Console.WriteLine("Cliente não existe! Por favor escolha outro cliente");
            return true;
        }else{
            return false;
        }


    }
    public void ShowBooks()
        {
            foreach (var book in _book)
            {
                Console.WriteLine($"Código: {book.id}  - Nome: {book.title}, Autor: {book.authorName}, Ano: {book.publisherYear}");
            }
        }

         public void ShowClients()
        {
            foreach (var client in _client )
            {
                Console.WriteLine($"Código: {client.id} - Nome do cliente {client.name}, Sobrenome: {client.lastName}, Ano Nascimento: {client.yearBirth}");
            }
        }

            public void registerClient(Client client)
            {
               _client.Add(client);
            }

}