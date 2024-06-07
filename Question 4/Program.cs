namespace HorseRacing {
  class Program {
    const int NUM_HORSES = 5;
    Random rnd = new Random();

    void init_horses(Horse[] horses) {
      for (int i = 0; i < NUM_HORSES; i++) {
        horses[i] = new Horse(i+1, rnd.Next(0, 11), false);
        Console.WriteLine(horses[i].print_horse());
      }
    }    

    void simulate_round(Horse[] horses) {
      foreach (Horse horse in horses) {
        if (!horse.finished) {
          horse.add_distance(rnd.Next(0, 11));
          Console.WriteLine(horse.print_horse());

          if (horse.distance >= 30) horse.finished = true;
        }
      }
    }

    Horse find_winner(Horse[] horses) {
      foreach (Horse horse in horses) {
        lowest = Math.Min(lowest, horse.distance);      
      }

    }

    static void Main(string[] args) {
      Program p = new Program();
      bool all_finished = false;
      int count = 0;
      Horse[] horses = new Horse[NUM_HORSES];

      p.init_horses(horses);

      while (!all_finished) {
        foreach (Horse horse in horses) {
          if (horse.finished) {
            count++;
          }

          if (count == 5) all_finished = true;
        }

        p.simulate_round(horses);
      }
    }
  }
}
