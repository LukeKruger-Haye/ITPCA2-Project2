namespace LinkedLists {
  class Program {
    struct Task {
      public string name;
      public string description;
    };

    static void welcome_screen() {
      Console.Clear();

      Console.WriteLine("Task manager:");
      Console.WriteLine("1. Add task");
      Console.WriteLine("2. Remove task");
      Console.WriteLine("3. List tasks");
      Console.WriteLine("4. Exit");

      Console.Write("User input: ");
    }

    void wait_for_user() {
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }

    void add_screen(LinkedList<Task> head) {
      string name;
      string description;

      Console.WriteLine("\nAdd task:");
    
      Console.Write("Name: ");
      name = Convert.ToString(Console.ReadLine());

      Console.Write("Description: ");
      description = Convert.ToString(Console.ReadLine());

      Task new_task;
      new_task.name = name;
      new_task.description = description;

      head.AddLast(new_task);
      Console.WriteLine("Task added");
      wait_for_user();
    }

    void remove_screen(LinkedList<Task> head) {
      bool found = false;
      string name = "";

      Console.WriteLine("Remove task:");
      
      Console.Write("Task to remove: ");
      name = Convert.ToString(Console.ReadLine());

      foreach (Task task in head) {
        if (task.name.ToLower() == name.ToLower()) {
          head.Remove(task);
          found = true;
          break;
        }
      }  

      if (!found) {
        Console.WriteLine($"Could not find the task, {name}");
      }

      Console.WriteLine("Task deleted");
      wait_for_user();
    }

    void print_list(LinkedList<Task> head) {
      Console.WriteLine("\nTask list:");

      foreach (Task task in head) {
        Console.WriteLine($"Name: {task.name}, Description: {task.description}"); 
      }

      wait_for_user();
    }

    void menu_select(ushort user_input, LinkedList<Task> head) {
      if (user_input == 1) add_screen(head);
      if (user_input == 2) remove_screen(head);
      if (user_input == 3) print_list(head);
      if (user_input == 4) System.Environment.Exit(1);

    }

    static void Main(string[] args)
    {
      Program p = new Program();
      LinkedList<Task> head = new LinkedList<Task>();

      ushort user_input;

      while (true) {
        welcome_screen();

        user_input = Convert.ToUInt16(Console.ReadLine());
        p.menu_select(user_input, head);
      }
    }
  }
}
