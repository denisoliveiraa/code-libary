
namespace MyClients;
public class Client {

  public int id;
  public string name;
  public string lastName;
  public int yearBirth;

    public Client(string name, string lastName, int yearBirth, int id)
    {
      this.id = id;
      this.name = name;
      this.lastName = lastName;
      this.yearBirth = yearBirth;
    }

    
}