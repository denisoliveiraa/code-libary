using System;
using MyLibary;
using MyClients;

namespace TodoList

{
  class Program
  {
    static void Main(String[] args){

      bool menuStarting = true;
      Library library = new Library();
      while(menuStarting){
          Console.WriteLine("1 - Cadastrar livro");
          Console.WriteLine("2 - Emprestar livros");
          Console.WriteLine("3 - Devolver livro");
          Console.WriteLine("4 - cadastrar Cliente");
          Console.WriteLine("5 - Verificar todos Cliente");
          Console.WriteLine("6 - Verificar todos livros");
          Console.WriteLine("7 - Sair");

          string res = Console.ReadLine();
          switch (res){
              case "1":
                Console.Clear();
                Console.WriteLine("Digite o nome do livro a ser cadastrado");
                string booketitle = Console.ReadLine();
                Console.WriteLine("Digite o subtítulo do livro a ser cadastrado");
                string bookSubtitle = Console.ReadLine();
                Console.WriteLine("Digite o autor do livro a ser cadastrado");
                string bookAuthor = Console.ReadLine();
                Console.WriteLine("Digite o ano de lançamento do livro");
                int BookReleaseYear = int.Parse(Console.ReadLine());
                
                library.registerBook(new Book(booketitle,bookSubtitle, bookAuthor, BookReleaseYear));
                
              break;
                case "2":
              
              break;
                case "3":
              
              break;
                case "4":
                  Console.Clear();

                Console.WriteLine("Digite o nome do Cliente a ser cadastrado");
                string clientName = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome do Cliente a ser cadastrado");
                string lastNameClient = Console.ReadLine();
                Console.WriteLine("Digite o ano de nascimento do Cliente");
                int yearbithClient = int.Parse(Console.ReadLine());

                library.registerClient(new Client(clientName,lastNameClient, yearbithClient));
                
              break;
              case "5":
                    Console.Clear();
                    library.ShowBooks();
              break;
              case "6":
                    Console.Clear();
                    library.ShowClients();
              break;
               case "7":
                    menuStarting = false;
                    Console.Clear();
              break;
    }
     }      
    }
  }
}



