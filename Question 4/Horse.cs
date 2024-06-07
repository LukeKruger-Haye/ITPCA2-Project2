public class Horse {
  public int id;
  public int distance;
  public bool finished;

  public Horse() {}

  public Horse(int id, int distance, bool finished) {
    this.id = id;
    this.distance = distance;
    this.finished = finished;
  }

  public void add_distance(int distance) {
    this.distance += distance;
  }

  public string print_horse() {
    return $"Horse {this.id}: Distance covered: {this.distance}";
  }
}
