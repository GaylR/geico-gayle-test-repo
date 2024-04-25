// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("StairCase");


//Build a square out of '*' of whatever size we want. 

int size = 4;   ///you could change the number her to widen

for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 4; j++)
    {
        System.Console.Write("*");
    }

    System.Console.WriteLine();  //sends to the next line
}


//Staircase Loops Challenge cont. 

//There are 3 other directions that the Staircase can "face"
//Build them all
//right staircase, left staircase, inverted stairs, inverted right facing
///manipulation of inner loop and Write statement


//Staircase example ****************
//***************************************************************************
 
int n = 10; 

        for (int i = 0; i < n; i++)
        {
            // Print spaces (n - i - 1)
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            // Print '*' (i + 1)
          {  for (int j = 0; j < i + 1; j++)
            {
                Console.Write("*");
            }

                     }
            System.Console.WriteLine();
        }
    

        for (int i = 0; i < n; i++)
        {
            // Print spaces (n - i - 1)
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write("*");
            }

            // Print ' ' (i + 1)
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write(" ");
            }

           System.Console.WriteLine();
        }

        

        
