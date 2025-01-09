using System;
using MyLibary;
using MyClients;
using System.Collections.Generic;

bool menuStarting = true;
Library library = new Library();
 library.registerBook(new Book("O Senhor dos Anéis", "A Sociedade do Anel", "J.R.R. Tolkien", 1954, 1, true));
 library.registerBook(new Book("Harry Potter", "A Pedra Filosofal", "J.K. Rowling", 1997, 2, true));
 library.registerBook(new Book("Dom Quixote", "A Jornada do Cavaleiro", "Miguel de Cervantes", 1605, 3, true));
 library.registerBook(new Book("1984", "O Grande Irmão", "George Orwell", 1949, 4, true));
 library.registerBook(new Book("O Pequeno Príncipe", "Uma Jornada no Deserto", "Antoine de Saint-Exupéry", 1943, 5, true));

 library.registerClient(new Client("João", "Silva", 1980, 1 ));
library.registerClient(new Client("Maria", "Oliveira", 1992, 2 ));
library.registerClient(new Client("Pedro", "Santos", 1985, 3));
library.registerClient(new Client("Ana", "Costa", 1990, 4));
library.registerClient(new Client("Lucas", "Almeida", 2000, 5));
int rangeBook = library.CountBooks;
int rangeClient = library.CountClient;


while (menuStarting)
{
    Console.WriteLine("1 - Cadastrar livro");
    Console.WriteLine("2 - Alugar um livro");
    Console.WriteLine("3 - Devolver livro");
    Console.WriteLine("4 - cadastrar Cliente");
    Console.WriteLine("5 - Verificar todos Cliente");
    Console.WriteLine("6 - Verificar todos livros");
    Console.WriteLine("7 - Sair");

    string res = Console.ReadLine();
    switch (res)
    {
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

            library.registerBook(new Book(booketitle, bookSubtitle, bookAuthor, BookReleaseYear, library.CountClient + 1, true));

            break;
        case "2":
        bool sequence = true;
        
        while(sequence){
            Console.Clear();
            library.ShowBooks();
            Console.WriteLine("Digite o numero do ID do livro escolhido");
            int idBookChoice = int.Parse(Console.ReadLine());
            sequence = library.FindBook(idBookChoice);

        }
        sequence = true;
        while(sequence){ 
            Console.Clear();
            library.ShowClients();
            Console.WriteLine("Digite o numero do ID do Cliente escolhido");
            int idClientChoice = int.Parse(Console.ReadLine());
            sequence = library.FindClient(idClientChoice);
        }
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
            
         
            library.registerClient(new Client(clientName, lastNameClient, yearbithClient, library.CountBooks + 1));

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



