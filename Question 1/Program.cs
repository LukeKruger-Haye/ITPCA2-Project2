using System;

namespace Project {
  class SoccerMS {
    List<Player> players = new List<Player>();

    static void welcome_screen() {
      Console.Clear();

      Console.WriteLine("Welcome to the Soccer Player Management System!\n");
      Console.WriteLine("Menu:");
      Console.WriteLine("1. Add a Player");
      Console.WriteLine("2. Remove a Player");
      Console.WriteLine("3. Search for a Player");
      Console.WriteLine("4. Display all Players");
      Console.WriteLine("5. Exit");
      Console.Write("Enter your choice: ");
    }

    void wait_for_user() {
      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }

    void add_screen() {
      string name, position;
      ushort age;

      Console.WriteLine("\nEnter player details:");
      try {
        Console.Write("Name: ");
        name = Convert.ToString(Console.ReadLine());

        if (name == string.Empty) throw new InvalidInputException();
      
        Console.Write("Age:");
        age = Convert.ToUInt16(Console.ReadLine());
       
        Console.Write("Position:");
        position = Convert.ToString(Console.ReadLine());

        if (position == string.Empty) throw new InvalidInputException();

        players.Add(new Player(name, age, position));

        Console.WriteLine("Player added successfully!");
        wait_for_user();
      } catch (Exception ex) {
        Console.WriteLine(ex);
      }
    }
    
    void remove_screen() {
      string name;
      bool found = false;

      Console.Write("Enter the name of the player to delete: ");
      name = Console.ReadLine();

      foreach (Player player in players) {
        if (player.get_name().ToLower() == name.ToLower()) {
          players.Remove(player);
          Console.WriteLine("Player deleted");
          found = true;
          break;
        }
      }

      if (!found) {
        Console.WriteLine("Player not found");
      }

      wait_for_user();
    }

    void search_screen() {
      string name;
      bool found = false;

      Console.Write("Enter the name of the player to search: ");
      name = Console.ReadLine();

      foreach (Player player in players) {
        if (player.get_name().ToLower() == name.ToLower()) {
          Console.WriteLine(player.ToString());
          found = true;
          break;
        }
      }

      if (!found) {
        Console.WriteLine("Player not found");
      }

      wait_for_user();
    }

    void roster_screen() {
      Console.WriteLine("\nList of players:");

      foreach (Player player in players) {
        Console.WriteLine(player.ToString());
      }

      wait_for_user();
    }

    void menu_select(ushort user_input) {
      if (user_input == 1) add_screen();
      if (user_input == 2) remove_screen();
      if (user_input == 3) search_screen();
      if (user_input == 4) roster_screen();
      if (user_input == 5) System.Environment.Exit(1); 
    }

    static void Main(string[] args) {
      SoccerMS program = new SoccerMS();
      ushort user_input;

      while (true) {
        welcome_screen();
        user_input = Convert.ToUInt16(Console.ReadLine());
        program.menu_select(user_input);
      }
    }
  }
}
