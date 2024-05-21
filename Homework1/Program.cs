
namespace MyApp


{
    class Program: ExampleClass
    {
        static void Main(string[] args)
        {
           
            // Instantiate both classes
            ExampleClass example1 = new ExampleClass();
            HolderClass example2 = new HolderClass();

            
            // Call the method in ExampleClass
            example1.FirstOne();
                  
                                   
            
            // Print out the field of the HolderClass
            System.Console.WriteLine(example2.name);
 
 
            // Once these are working, put the ExampleClass in it's own file and namespace
            // Then run the code, and try to get it working
 
            // Next put the HolderClass in it's own file, and unique namespace
            // Run the code again, and try to get it working
        }
    }
 
  
}
//has context menu





