namespace Homework3p2;
class Program
{
    static void Main(string[] args)
    {
     Console.WriteLine("Assign an int value to N: "); //Asking user to input a number
        int n = Convert.ToInt16(Console.ReadLine());
        
        for(int row = 0;row < n;row++){ 
            
        for(int col = 0; col < n ;col++){
            Console.Write("#");
        }
            Console.WriteLine();
        }   
    }
}
