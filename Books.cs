
namespace MyLibary {
    public class Book {
      public string title;
      public string subtitle;
      public string authorName;
      public int publisherYear;

      public int id; 

      public bool available;


          public Book(string title, string subtitle, string authorName, int publisherYear, int id, bool available) {
              this.title = title;
              this.subtitle = subtitle;
              this.authorName = authorName;
              this.publisherYear = publisherYear;
              this.id = id;
              this.available = available;
          }
    }
}