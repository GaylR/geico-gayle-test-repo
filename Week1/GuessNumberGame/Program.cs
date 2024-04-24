// See https://aka.ms/new-console-template for more information

string textToCenter = "Welcome!";
System.Console.SetCursorPosition((Console.WindowWidth - textToCenter.Length) / 2, Console.CursorTop);
Console.WriteLine(textToCenter);

System.Console.WriteLine("\nGuess A Number Between 1 - 100!");


            // Set your desired number
                        
       {
      {

        int setNumber = 7; 
        int Guess = 0;
        
       while (Guess != setNumber) 

        
        
       { System.Console.WriteLine("I am thinking of a number between 1 and 100. Can you guess what it is?");
        string? input = Console.ReadLine();
        
      
        {
                    
            if (Guess < setNumber)
            {
                System.Console.WriteLine("Your guess is too low! Please try again!");
            }

            else 
            
            if (Guess > setNumber)
            {
                System.Console.WriteLine("Your guess is too high! Please try again!");
            }
           
             else
             {
                System.Console.WriteLine("Well done! You guessed correctly!"); 
             }
        

            }
      }
    System.Console.WriteLine();
      }
}