using System.ComponentModel.DataAnnotations;

namespace OOP_lab1_zavd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side of the rectangle!");
            Side rectangle = new Side(0, 0);
            Console.Write("Enter the length: ");
            rectangle[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width: ");
            rectangle[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(rectangle.Area());
        }
    }
}
