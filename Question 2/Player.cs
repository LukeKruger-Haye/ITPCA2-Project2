public class Player {
  public enum Position {
    Goalkeeper,
    Defender,
    Midfielder,
    Winger,
    Striker
  }

  private string name;
  private ushort age;
  private Position position;

  public Player() {}

  public Player(string name, ushort age, string position) {
    this.name = name;
    this.age = age;

    switch (position.ToLower()) {
      case "goalkeeper":
        this.position = Position.Goalkeeper;
        break;
      case "defender":
        this.position = Position.Defender;
        break;
      case "midfielder":
        this.position = Position.Midfielder;
        break;
      case "winger":
        this.position = Position.Winger;
        break;
      case "striker":
        this.position = Position.Striker;
        break;

      default:
        throw new InvalidInputException();
        break;
    }
  }

  public string get_name() {
    return this.name;
  } 

  public ushort get_age() {
    return this.age;
  }

  public Position get_position() {
    return this.position;
  }

  public string ToString() {
    return $"Name: {this.name}, Age: {this.age}, Position: {this.position}";
  }

  public string ToLine() {
    return $"{this.name} {this.age}, {this.position}";
  }
}
