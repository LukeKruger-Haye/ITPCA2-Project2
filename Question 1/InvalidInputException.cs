class InvalidInputException : ApplicationException {
  public InvalidInputException() {
    Console.WriteLine("Exception occured: Invalid input");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
  }

  public void PrintError() {
    Console.WriteLine("Exception occured: Invalid input");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
  }
}
