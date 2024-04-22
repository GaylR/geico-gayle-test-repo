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
        
       
        System.Console.WriteLine("\nI am thinking of a number between 1 and 100. Can you guess what it is?");

        while (Guess != setNumber)
        {
            Guess = Convert.ToInt32(Console.ReadLine());

            if (Guess < setNumber)
            {
                System.Console.WriteLine($"No, the number I am thinking of is higher than {Guess}. Can you guess what it is?");
            }
            else 
            
            if (Guess > setNumber)
            {
                System.Console.WriteLine($"No, the number I am thinking of is lower than {Guess}. Can you guess what it is?");
            }
          
        }

        System.Console.WriteLine($"Well done! The answer was {setNumber}.");
    }
}