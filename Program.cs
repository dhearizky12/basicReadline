class Program {
   static void Main () {

       Console.Write("input your name = ");
       string? userInputName = Console.ReadLine();
       Console.Write("input your age = ");
       string? userInputAge = Console.ReadLine();


    Console.WriteLine("Hello, "+ userInputName + " ! " + "You are " + userInputAge + " year");
   //  Console.WriteLine ( $"Hello, {userInputName} {userInputAge}");
    }
}